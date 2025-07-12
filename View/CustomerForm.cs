using System.ComponentModel;
using EShift_App.Data.Repositories;
using EShift_App.Model;

namespace EShift_App.View;

public partial class CustomerForm : Form
{
    private readonly ICustomerRepository _customerRepository;
    private BindingList<Customer> _customersBindingList;
    private Customer? _selectedCustomer;

    public CustomerForm(ICustomerRepository customerRepository)
    {
        InitializeComponent();
        _customerRepository = customerRepository;

        // Initialize the binding list for real-time UI updates
        _customersBindingList = new BindingList<Customer>();
    }

    private async void CustomerForm_Load(object sender, EventArgs e)
    {
        // Setup DataGridView and load initial data
        SetupDataGridView();
        await LoadCustomersAsync();
        SetFormState(FormState.Viewing);
    }

    private void SetupDataGridView()
    {
        // Set the data source once. The BindingList handles updates.
        dataGridViewCustomers.DataSource = _customersBindingList;
        dataGridViewCustomers.AutoGenerateColumns = false;

        // Define columns manually for better control
        dataGridViewCustomers.Columns.Clear();
        dataGridViewCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "First Name", Width = 120 });
        dataGridViewCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Last Name", Width = 120 });
        dataGridViewCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Phone Number", Width = 120 });
        dataGridViewCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

        // Handle selection change
        dataGridViewCustomers.SelectionChanged += DataGridViewCustomers_SelectionChanged;
    }

    private async Task LoadCustomersAsync()
    {
        var customers = await _customerRepository.GetAllAsync();
        _customersBindingList.Clear();
        foreach (var customer in customers)
        {
            _customersBindingList.Add(customer);
        }
    }

    private void DataGridViewCustomers_SelectionChanged(object? sender, EventArgs e)
    {
        if (dataGridViewCustomers.CurrentRow?.DataBoundItem is Customer customer)
        {
            _selectedCustomer = customer;
            DisplayCustomerDetails();
            SetFormState(FormState.Viewing);
        }
    }

    private void DisplayCustomerDetails()
    {
        if (_selectedCustomer != null)
        {
            txtFirstName.Text = _selectedCustomer.FirstName;
            txtLastName.Text = _selectedCustomer.LastName;
            txtPhoneNumber.Text = _selectedCustomer.PhoneNumber;
            txtEmail.Text = _selectedCustomer.Email;
            txtAddress.Text = _selectedCustomer.Address;
        }
    }

    private void ClearInputFields()
    {
        txtFirstName.Clear();
        txtLastName.Clear();
        txtPhoneNumber.Clear();
        txtEmail.Clear();
        txtAddress.Clear();
        _selectedCustomer = null;
        dataGridViewCustomers.ClearSelection();
    }

    // Search button click event
    private async void btnSearch_Click(object sender, EventArgs e)
    {
        var customers = await _customerRepository.SearchAsync(txtSearch.Text);
        _customersBindingList.Clear();
        foreach (var customer in customers)
        {
            _customersBindingList.Add(customer);
        }
    }

    // "Add New" button to prepare for adding a new customer
    private void btnAddNew_Click(object sender, EventArgs e)
    {
        SetFormState(FormState.Adding);
    }

    // "Save" button to add a new or update an existing customer
    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;

        if (_selectedCustomer == null) // We are adding a new customer
        {
            var newCustomer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                RegistrationDate = DateTime.Now
            };
            await _customerRepository.AddAsync(newCustomer);
            _customersBindingList.Add(newCustomer); // Add to list for UI update
        }
        else // We are updating an existing customer
        {
            _selectedCustomer.FirstName = txtFirstName.Text;
            _selectedCustomer.LastName = txtLastName.Text;
            _selectedCustomer.PhoneNumber = txtPhoneNumber.Text;
            _selectedCustomer.Email = txtEmail.Text;
            _selectedCustomer.Address = txtAddress.Text;
            _customerRepository.Update(_selectedCustomer);
            _customersBindingList.ResetItem(_customersBindingList.IndexOf(_selectedCustomer)); // Refresh grid
        }

        await _customerRepository.SaveChangesAsync();
        MessageBox.Show("Customer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        SetFormState(FormState.Viewing);
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
            string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
            string.IsNullOrWhiteSpace(txtAddress.Text))
        {
            MessageBox.Show("First Name, Phone Number, and Address are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Manages the enabled/disabled state of form controls.
    /// </summary>
    private void SetFormState(FormState state)
    {
        // Details panel is read-only when just viewing
        panelDetails.Enabled = (state == FormState.Adding || state == FormState.Editing);

        btnSave.Enabled = (state == FormState.Adding || state == FormState.Editing);
        btnCancel.Enabled = (state == FormState.Adding || state == FormState.Editing);
        btnAddNew.Enabled = (state == FormState.Viewing);

        if (state == FormState.Adding)
        {
            ClearInputFields();
            txtFirstName.Focus();
        }
    }

    // Cancel button to revert changes
    private void btnCancel_Click(object sender, EventArgs e)
    {
        // If we were editing, restore the original details
        if (_selectedCustomer != null)
        {
            DisplayCustomerDetails();
        }
        else // If we were adding, just clear the fields
        {
            ClearInputFields();
        }
        SetFormState(FormState.Viewing);
    }
}

// Enum to manage form state for clarity
internal enum FormState { Viewing, Adding, Editing }