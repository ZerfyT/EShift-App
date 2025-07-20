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

        _customersBindingList = new BindingList<Customer>();
    }

    private async void CustomerForm_Load(object sender, EventArgs e)
    {
        SetupDataGridView();
        await LoadCustomersAsync();
        SetFormState(FormState.Viewing);
    }

    private void SetupDataGridView()
    {
        dataGridViewCustomers.DataSource = _customersBindingList;
        dataGridViewCustomers.AutoGenerateColumns = false;

        dataGridViewCustomers.Columns.Clear();
        dataGridViewCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "First Name", Width = 120 });
        dataGridViewCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Last Name", Width = 120 });
        dataGridViewCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Phone Number", Width = 120 });
        dataGridViewCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

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

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        var customers = await _customerRepository.SearchAsync(txtSearch.Text);
        _customersBindingList.Clear();
        foreach (var customer in customers)
        {
            _customersBindingList.Add(customer);
        }
    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
        SetFormState(FormState.Adding);
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;

        if (_selectedCustomer == null)
        {
            var newCustomer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                RegistrationDate = DateTime.Now,
                PasswordHash = "1234",
                Role = "Customer"
            };
            await _customerRepository.AddAsync(newCustomer);
            _customersBindingList.Add(newCustomer);
        }
        else 
        {
            _selectedCustomer.FirstName = txtFirstName.Text;
            _selectedCustomer.LastName = txtLastName.Text;
            _selectedCustomer.PhoneNumber = txtPhoneNumber.Text;
            _selectedCustomer.Email = txtEmail.Text;
            _selectedCustomer.Address = txtAddress.Text;
            _customerRepository.Update(_selectedCustomer);
            _customersBindingList.ResetItem(_customersBindingList.IndexOf(_selectedCustomer));
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

    private void SetFormState(FormState state)
    {
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

    private void btnCancel_Click(object sender, EventArgs e)
    {
        if (_selectedCustomer != null)
        {
            DisplayCustomerDetails();
        }
        else
        {
            ClearInputFields();
        }
        SetFormState(FormState.Viewing);
    }
}
internal enum FormState { Viewing, Adding, Editing }
