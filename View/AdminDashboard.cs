using System.ComponentModel;
using System.Text;
using EShift_App.Data.Repositories;
using EShift_App.Model;
using Microsoft.Extensions.DependencyInjection;

namespace EShift_App.View
{
    public partial class AdminDashboard : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IJobRepository _jobRepository;
        private readonly ILoadRepository _loadRepository;
        private readonly ILorryRepository _lorryRepository;
        private readonly IDriverRepository _driverRepository;
        private readonly IAssistantRepository _assistantRepository;
        private readonly ITransportUnitRepository _transportUnitRepository;

        private BindingList<Job> _pendingJobsBindingList;
        private BindingList<Load> _loadsBindingList;
        private BindingList<Job> _allJobsBindingList;

        private Job? _selectedJob;
        private Load? _selectedLoad;

        public AdminDashboard(
            IServiceProvider serviceProvider, 
            IJobRepository jobRepository, 
            ILoadRepository loadRepository, 
            ILorryRepository lorryRepository, 
            IDriverRepository driverRepository, 
            IAssistantRepository assistantRepository, 
            ITransportUnitRepository transportUnitRepository)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _jobRepository = jobRepository;
            _loadRepository = loadRepository;
            _lorryRepository = lorryRepository;
            _driverRepository = driverRepository;
            _assistantRepository = assistantRepository;
            _transportUnitRepository = transportUnitRepository;

            _pendingJobsBindingList = new BindingList<Job>();
            _loadsBindingList = new BindingList<Load>();
            _allJobsBindingList = new BindingList<Job>();
        }

        private async void AdminDashboard_Load(object sender, EventArgs e)
        {
            SetupDataGridViews();
            await LoadInitialData();
        }

        private void SetupDataGridViews()
        {
            dgvPendingJobs.DataSource = _pendingJobsBindingList;
            dgvPendingJobs.AutoGenerateColumns = false;
            dgvPendingJobs.Columns.Clear();
            dgvPendingJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "JobNumber", HeaderText = "Job Number", Width = 120 });
            dgvPendingJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Customer.FullName", HeaderText = "Customer", Width = 150 });
            dgvPendingJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "JobDate", HeaderText = "Date", Width = 100 });
            dgvPendingJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StartLocation", HeaderText = "From", Width = 200 });
            dgvPendingJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Destination", HeaderText = "To", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPendingJobs.SelectionChanged += dgvPendingJobs_SelectionChanged;

            dgvLoads.DataSource = _loadsBindingList;
            dgvLoads.AutoGenerateColumns = false;
            dgvLoads.Columns.Clear();
            dgvLoads.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LoadNumber", HeaderText = "Load Number", Width = 150 });
            dgvLoads.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GoodsDescription", HeaderText = "Description", Width = 250 });
            dgvLoads.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TransportUnitID", HeaderText = "Unit ID", Width = 80 });
            dgvLoads.SelectionChanged += dgvLoads_SelectionChanged;

            dgvAllJobs.DataSource = _allJobsBindingList;
        }

        private async Task LoadInitialData()
        {
            var pendingJobs = await _jobRepository.GetJobsByStatusAsync("Pending");
            _pendingJobsBindingList.Clear();
            foreach (var job in pendingJobs) _pendingJobsBindingList.Add(job);

            var allJobs = await _jobRepository.SearchJobsAsync("");
            _allJobsBindingList.Clear();
            foreach (var job in allJobs) _allJobsBindingList.Add(job);

            await LoadComboBoxes();
        }

        private async Task LoadComboBoxes()
        {
            cmbLorry.DataSource = await _lorryRepository.GetAllAsync();
            cmbLorry.DisplayMember = "RegistrationNumber";
            cmbLorry.ValueMember = "LorryID";

            cmbDriver.DataSource = await _driverRepository.GetAllAsync();
            cmbDriver.DisplayMember = "FullName";
            cmbDriver.ValueMember = "DriverID";

            cmbAssistant.DataSource = await _assistantRepository.GetAllAsync();
            cmbAssistant.DisplayMember = "FullName";
            cmbAssistant.ValueMember = "AssistantID";
        }

        private async void dgvPendingJobs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPendingJobs.CurrentRow?.DataBoundItem is Job job)
            {
                _selectedJob = job;
                DisplayJobDetails();
                await LoadLoadsForJob();
            }
        }

        private void dgvLoads_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoads.CurrentRow?.DataBoundItem is Load load)
            {
                _selectedLoad = load;
                // TODO
            }
        }

        private void DisplayJobDetails()
        {
            if (_selectedJob == null)
            {
                lblJobDetails.Text = "Select a job to see details...";
                return;
            }

            var details = new StringBuilder();
            details.AppendLine($"Job Number: {_selectedJob.JobNumber}");
            details.AppendLine($"Customer: {_selectedJob.Customer.FullName}");
            details.AppendLine($"Phone: {_selectedJob.Customer.PhoneNumber}");
            details.AppendLine($"Date: {_selectedJob.JobDate:D}");
            details.AppendLine();
            details.AppendLine($"From: {_selectedJob.StartLocation}");
            details.AppendLine($"To: {_selectedJob.Destination}");

            lblJobDetails.Text = details.ToString();
            cmbJobStatus.SelectedItem = _selectedJob.Status;
        }

        private async Task LoadLoadsForJob()
        {
            _loadsBindingList.Clear();
            if (_selectedJob == null) return;

            var loads = await _loadRepository.GetLoadsByJobIdAsync(_selectedJob.JobID);
            foreach (var load in loads)
            {
                _loadsBindingList.Add(load);
            }
        }

        private async void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (_selectedJob == null)
            {
                MessageBox.Show("Please select a job first.", "No Job Selected");
                return;
            }

            _selectedJob.Status = cmbJobStatus.SelectedItem.ToString();
            _jobRepository.Update(_selectedJob);
            await _jobRepository.SaveChangesAsync();

            MessageBox.Show("Job status updated successfully.", "Success");
            await LoadInitialData(); // Refresh the lists
        }

        private async void btnAssignUnit_Click(object sender, EventArgs e)
        {
            if (_selectedLoad == null)
            {
                MessageBox.Show("Please select a load from the 'Loads' grid first.", "No Load Selected");
                return;
            }

            var lorryId = (int)cmbLorry.SelectedValue;
            var driverId = (int)cmbDriver.SelectedValue;
            var assistantId = (int)cmbAssistant.SelectedValue;

            var transportUnit = await _transportUnitRepository.FindOrCreateAsync(lorryId, driverId, assistantId);

            _selectedLoad.TransportUnitID = transportUnit.TransportUnitID;
            _loadRepository.Update(_selectedLoad);
            await _loadRepository.SaveChangesAsync();

            MessageBox.Show($"Transport Unit #{transportUnit.TransportUnitID} assigned to Load #{_selectedLoad.LoadNumber}.", "Success");
            await LoadLoadsForJob(); // Refresh the loads grid
        }

        private async void btnSearchJobs_Click(object sender, EventArgs e)
        {
            var jobs = await _jobRepository.SearchJobsAsync(txtSearchJobs.Text);
            _allJobsBindingList.Clear();
            foreach (var job in jobs) _allJobsBindingList.Add(job);
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excel export functionality requires a third-party library and is not yet implemented.", "Info");
        }

        private async void btnAddLoad_Click(object sender, EventArgs e)
        {
            if (_selectedJob == null)
            {
                MessageBox.Show("Please select a job before adding a load.", "No Job Selected");
                return;
            }

            using var editorForm = _serviceProvider.GetRequiredService<LoadEditorForm>();

            if (editorForm.ShowDialog() == DialogResult.OK)
            {
                var newLoad = editorForm.EditedLoad;
                newLoad.JobID = _selectedJob.JobID;

                // Generate a new load number
                int nextLoadIndex = _loadsBindingList.Count + 1;
                newLoad.LoadNumber = $"{_selectedJob.JobNumber}-L{nextLoadIndex}";

                await _loadRepository.AddAsync(newLoad);
                await _loadRepository.SaveChangesAsync();
                await LoadLoadsForJob(); // Refresh grid
            }
        }

        private async void btnEditLoad_Click(object sender, EventArgs e)
        {
            if (_selectedLoad == null)
            {
                MessageBox.Show("Please select a load to edit.", "No Load Selected");
                return;
            }

            // Pass the selected load to the editor's constructor
            using var editorForm = new LoadEditorForm(_selectedLoad);

            if (editorForm.ShowDialog() == DialogResult.OK)
            {
                var editedData = editorForm.EditedLoad;

                // Update the selected load with the new data
                _selectedLoad.GoodsDescription = editedData.GoodsDescription;
                _selectedLoad.Weight = editedData.Weight;
                _selectedLoad.Volume = editedData.Volume;

                _loadRepository.Update(_selectedLoad);
                await _loadRepository.SaveChangesAsync();
                await LoadLoadsForJob();
            }
        }

        private async void btnDeleteLoad_Click(object sender, EventArgs e)
        {
            if (_selectedLoad == null)
            {
                MessageBox.Show("Please select a load to delete.", "No Load Selected");
                return;
            }

            var confirmResult = MessageBox.Show($"Are you sure you want to delete Load #{_selectedLoad.LoadNumber}?",
                                             "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                _loadRepository.Delete(_selectedLoad);
                await _loadRepository.SaveChangesAsync();
                await LoadLoadsForJob(); // Refresh grid
            }
        }
    }
}