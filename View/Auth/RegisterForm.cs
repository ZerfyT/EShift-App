using EShift_App.Data.Repositories;
using EShift_App.Model;
using EShift_App.Data;

namespace EShift_App.View.Auth;

public partial class RegisterForm : Form
{
    private readonly ICustomerRepository _customerRepository;

    public RegisterForm(ICustomerRepository customerRepository)
    {
        InitializeComponent();
        _customerRepository = customerRepository;
    }

    private async void btnRegister_Click(object sender, EventArgs e)
    {
        if (txtPassword.Text != txtConfirmPassword.Text)
        {
            MessageBox.Show("Passwords do not match.", "Error");
            return;
        }

        if (await _customerRepository.GetByEmailAsync(txtEmail.Text) != null)
        {
            MessageBox.Show("An account with this email already exists.", "Error");
            return;
        }

        // ** Create new customer **
        var newCustomer = new Customer
        {
            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            PhoneNumber = txtPhoneNumber.Text,
            Email = txtEmail.Text,
            Address = txtAddress.Text,
            PasswordHash = PasswordHelper.HashPassword(txtPassword.Text),
            Role = "Customer",
            RegistrationDate = DateTime.Now
        };

        await _customerRepository.AddAsync(newCustomer);
        await _customerRepository.SaveChangesAsync();

        MessageBox.Show("Registration successful! You can now log in.", "Success");
        this.Close();
    }
}

