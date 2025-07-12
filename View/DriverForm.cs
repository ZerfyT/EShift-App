using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using EShift_App.Data.Repositories;
using EShift_App.Model;

namespace EShift_App.View;

public partial class DriverForm : Form
{
    private readonly IDriverRepository _driverRepository;
    private BindingList<Driver> _driversBindingList;
    private Driver? _selectedDriver;

    public DriverForm(IDriverRepository driverRepository)
    {
        InitializeComponent();
        _driverRepository = driverRepository;
        _driversBindingList = new BindingList<Driver>();
    }

    private async void DriverForm_Load(object sender, EventArgs e)
    {
        SetupDataGridView();
        await LoadDriversAsync();
        SetFormState(FormState.Viewing);
    }

    private void SetupDataGridView()
    {
        dataGridViewDrivers.DataSource = _driversBindingList;
        dataGridViewDrivers.AutoGenerateColumns = false;

        // Define columns for the Driver model
        dataGridViewDrivers.Columns.Clear();
        dataGridViewDrivers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "First Name", Width = 120 });
        dataGridViewDrivers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Last Name", Width = 120 });
        dataGridViewDrivers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Phone Number", Width = 120 });
        dataGridViewDrivers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LicenseNumber", HeaderText = "License Number", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

        dataGridViewDrivers.SelectionChanged += DataGridViewDrivers_SelectionChanged;
    }

    private async Task LoadDriversAsync()
    {
        var drivers = await _driverRepository.GetAllAsync();
        _driversBindingList.Clear();
        foreach (var driver in drivers)
        {
            _driversBindingList.Add(driver);
        }
    }

    private void DataGridViewDrivers_SelectionChanged(object? sender, EventArgs e)
    {
        if (dataGridViewDrivers.CurrentRow?.DataBoundItem is Driver driver)
        {
            _selectedDriver = driver;
            DisplayDriverDetails();
            SetFormState(FormState.Viewing);
        }
    }

    private void DisplayDriverDetails()
    {
        if (_selectedDriver != null)
        {
            txtFirstName.Text = _selectedDriver.FirstName;
            txtLastName.Text = _selectedDriver.LastName;
            txtPhoneNumber.Text = _selectedDriver.PhoneNumber;
            txtLicenseNumber.Text = _selectedDriver.LicenseNumber;
        }
    }

    private void ClearInputFields()
    {
        txtFirstName.Clear();
        txtLastName.Clear();
        txtPhoneNumber.Clear();
        txtLicenseNumber.Clear();
        _selectedDriver = null;
        dataGridViewDrivers.ClearSelection();
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        var drivers = await _driverRepository.SearchAsync(txtSearch.Text);
        _driversBindingList.Clear();
        foreach (var driver in drivers)
        {
            _driversBindingList.Add(driver);
        }
    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
        SetFormState(FormState.Adding);
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;

        int? driverIdToIgnore = _selectedDriver?.DriverID;
        if (await _driverRepository.LicenseNumberExistsAsync(txtLicenseNumber.Text, driverIdToIgnore))
        {
            MessageBox.Show("A driver with this license number already exists.", "Duplicate License Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (_selectedDriver == null) // Add new driver
        {
            var newDriver = new Driver
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                LicenseNumber = txtLicenseNumber.Text,
                HireDate = DateTime.Now
            };
            await _driverRepository.AddAsync(newDriver);
            _driversBindingList.Add(newDriver);
        }
        else // Update existing driver
        {
            _selectedDriver.FirstName = txtFirstName.Text;
            _selectedDriver.LastName = txtLastName.Text;
            _selectedDriver.PhoneNumber = txtPhoneNumber.Text;
            _selectedDriver.LicenseNumber = txtLicenseNumber.Text;
            _driverRepository.Update(_selectedDriver);
            _driversBindingList.ResetItem(_driversBindingList.IndexOf(_selectedDriver));
        }

        await _driverRepository.SaveChangesAsync();
        MessageBox.Show("Driver saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        SetFormState(FormState.Viewing);
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedDriver == null)
        {
            MessageBox.Show("Please select a driver to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show($"Are you sure you want to delete {_selectedDriver.FirstName} {_selectedDriver.LastName}?",
                                         "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            _driverRepository.Delete(_selectedDriver);
            await _driverRepository.SaveChangesAsync();
            _driversBindingList.Remove(_selectedDriver);
            ClearInputFields();
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        if (_selectedDriver != null)
        {
            DisplayDriverDetails();
        }
        else
        {
            ClearInputFields();
        }
        SetFormState(FormState.Viewing);
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
            string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
            string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
        {
            MessageBox.Show("First Name, Phone Number, and License Number are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void SetFormState(FormState state)
    {
        panelDetails.Enabled = (state == FormState.Adding || state == FormState.Editing);
        btnSave.Enabled = (state == FormState.Adding || state == FormState.Editing);
        btnCancel.Enabled = (state == FormState.Adding || state == FormState.Editing);
        btnAddNew.Enabled = (state == FormState.Viewing);
        btnDelete.Enabled = (state == FormState.Viewing && _selectedDriver != null);

        if (state == FormState.Adding)
        {
            ClearInputFields();
            txtFirstName.Focus();
        }
    }
}