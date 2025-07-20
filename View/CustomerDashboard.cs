using System.ComponentModel;
using EShift_App.Data.Repositories;
using EShift_App.Model;
using EShift_App.Service;

namespace EShift_App.View
{
    public partial class CustomerDashboard : Form
    {
        private readonly IJobService _jobService;
        private readonly IJobRepository _jobRepository;
        private readonly Customer _loggedInCustomer;
        private BindingList<Job> _jobsBindingList;

        public CustomerDashboard(IJobService jobService, IJobRepository jobRepository, Customer loggedInCustomer)
        {
            InitializeComponent();
            _jobService = jobService;
            _jobRepository = jobRepository;
            _loggedInCustomer = loggedInCustomer;
            _jobsBindingList = new BindingList<Job>();
        }

        private async void CustomerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_loggedInCustomer.FullName}!";
            SetupJobsDataGridView();
            await LoadCustomerJobsAsync();
        }

        private void SetupJobsDataGridView()
        {
            dgvMyJobs.DataSource = _jobsBindingList;
            dgvMyJobs.AutoGenerateColumns = false;
            dgvMyJobs.Columns.Clear();
            dgvMyJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "JobNumber", HeaderText = "Job Number", Width = 150 });
            dgvMyJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "JobDate", HeaderText = "Date", Width = 120 });
            dgvMyJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StartLocation", HeaderText = "From", Width = 200 });
            dgvMyJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Destination", HeaderText = "To", Width = 200 });
            dgvMyJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        }

        private async Task LoadCustomerJobsAsync()
        {
            var myJobs = await _jobRepository.GetJobsByCustomerIdAsync(_loggedInCustomer.CustomerID);

            _jobsBindingList.Clear();
            foreach (var job in myJobs)
            {
                _jobsBindingList.Add(job);
            }
        }

        private async void btnPlaceJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStartLocation.Text) || string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Please fill in both pickup and destination addresses.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await _jobService.PlaceNewJobAsync(
                    _loggedInCustomer.CustomerID,
                    txtStartLocation.Text,
                    txtDestination.Text,
                    dtpJobDate.Value,
                    txtGoodsDescription.Text,
                    numWeight.Value,
                    numVolume.Value
                );

                MessageBox.Show("Your job request has been placed successfully! We will contact you shortly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearJobCreationForm();
                tabControlMain.SelectedTab = tabPageMyJobs;
                await LoadCustomerJobsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while placing your job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearJobCreationForm()
        {
            txtStartLocation.Clear();
            txtDestination.Clear();
            txtGoodsDescription.Clear();
            numWeight.Value = 0;
            numVolume.Value = 0;
            dtpJobDate.Value = DateTime.Now;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadCustomerJobsAsync();
        }
    }
}
