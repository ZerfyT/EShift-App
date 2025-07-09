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

    private async void CustomersForm_Load(object sender, EventArgs e)
    {
        // Setup DataGridView and load initial data
        SetupDataGridView();
        await LoadCustomersAsync();
        SetFormState(FormState.Viewing);
    }
}