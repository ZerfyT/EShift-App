using EShift_App.Data;
using EShift_App.Data.Repositories;
using EShift_App.Model;
using EShift_App.View;
using EShift_App.View.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;

namespace EShift_App
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            var services = host.Services;

            // ** Check the database connection before start **
            if (!await CanConnectToDatabase(host.Services))
            {
                MessageBox.Show(
                    "Failed to connect to the database. Please check your connection string and ensure the MySQL server is running.",
                    "Database Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // ** Start the login flow **
            var loginForm = services.GetRequiredService<LoginForm>();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                var loggedInUser = loginForm.LoggedInCustomer;

                if (loggedInUser.Role == "Admin")
                {
                    var adminDashboard = services.GetRequiredService<Layout>();
                    Application.Run(adminDashboard);
                }
                else
                {
                    var customerDashboard = new CustomerDashboard(
                        services.GetRequiredService<IRepository<Job>>(),
                        services.GetRequiredService<IRepository<Load>>(),
                        loggedInUser
                    );
                    Application.Run(customerDashboard);
                }
            }
            else
            {
                Application.Exit();
            }

            // ** Configures all the application's services for dependency injection. **
            static IHostBuilder CreateHostBuilder() =>
                Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
                    services.AddDbContext<AppDbContext>(options =>
                       options.UseMySQL(connectionString));

                    services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                    services.AddScoped<ICustomerRepository, CustomerRepository>();
                    services.AddScoped<IDriverRepository, DriverRepository>();
                    services.AddScoped<IAssistantRepository, AssistantRepository>();
                    services.AddScoped<ILorryRepository, LorryRepository>();
                    services.AddScoped<ILoadRepository, LoadRepository>();
                    services.AddScoped<IJobRepository, JobRepository>();
                    services.AddScoped<ITransportUnitRepository, TransportUnitRepository>();

                    services.AddSingleton<Layout>();
                    services.AddTransient<CustomerForm>();
                    services.AddTransient<DriverForm>();
                    services.AddTransient<AssistantForm>();
                    services.AddTransient<LorryForm>();
                    //services.AddTransient<JobForm>();
                    services.AddTransient<CustomerDashboard>();
                    services.AddTransient<AdminDashboard>();
                    services.AddTransient<LoginForm>();
                    services.AddTransient<RegisterForm>();
                });

            //var mdiForm = host.Services.GetRequiredService<Layout>();
            //Application.Run(mdiForm);
        }

        private static async Task<bool> CanConnectToDatabase(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            try
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                return await dbContext.Database.CanConnectAsync();
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}