using System.ComponentModel;
using System.Linq;
using EShift_App.Data.Repositories;
using EShift_App.Model;

namespace EShift_App.View
{
    public partial class CustomerDashboard : Form
    {
        private readonly IRepository<Job> _jobRepository;
        //private readonly IRepository<Load> _loadRepository;
        private readonly Customer _loggedInCustomer;
        private BindingList<Job> _jobsBindingList;

        public CustomerDashboard(IRepository<Job> jobRepository, IRepository<Load> loadRepository, Customer loggedInCustomer)
        {
            InitializeComponent();
            _jobRepository = jobRepository;
            //_loadRepository = loadRepository;
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
            var allJobs = await _jobRepository.GetAllAsync();
            var myJobs = allJobs.Where(j => j.CustomerID == _loggedInCustomer.CustomerID)
                                .OrderByDescending(j => j.JobDate);

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

            var newJob = new Job
            {
                CustomerID = _loggedInCustomer.CustomerID,
                StartLocation = txtStartLocation.Text,
                Destination = txtDestination.Text,
                JobDate = dtpJobDate.Value,
                Status = "Pending",
                JobNumber = $"ESH-J{DateTime.Now:yyyyMMddHHmmss}",
                EstimatedWeight = numWeight.Value,
                GoodsDescription = txtGoodsDescription.Text
            };
            await _jobRepository.AddAsync(newJob);
            await _jobRepository.SaveChangesAsync();

            MessageBox.Show("Your job request has been placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtStartLocation.Clear();
            txtDestination.Clear();
            dtpJobDate.Value = DateTime.Now;
            txtGoodsDescription.Clear();
            numWeight.Value = 0;

            tabControlMain.SelectedTab = tabPageMyJobs;
            await LoadCustomerJobsAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadCustomerJobsAsync();
        }
    }
}