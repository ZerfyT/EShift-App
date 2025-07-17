using EShift_App.Data;
using EShift_App.Data.Repositories;
using EShift_App.Model;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace EShift_App.View.Auth;

public partial class LoginForm : Form
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IServiceProvider _serviceProvider;

    public bool LoginSuccessful { get; private set; }
    public Customer LoggedInCustomer { get; private set; }

    public LoginForm(ICustomerRepository customerRepository, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _customerRepository = customerRepository;
        _serviceProvider = serviceProvider;
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        var user = await _customerRepository.GetByEmailAsync(txtEmail.Text);
        Console.WriteLine(PasswordHelper.HashPassword("1234"));
        if (user != null && user.PasswordHash == txtPassword.Text)
        {
            LoginSuccessful = true;
            LoggedInCustomer = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        else
        {
            MessageBox.Show("Invalid email or password.", "Login Failed");
        }
    }

    private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var registerForm = _serviceProvider.GetRequiredService<RegisterForm>();
        registerForm.ShowDialog();
    }
}
