using EShift_App.Data;
using EShift_App.Data.Repositories;
using EShift_App.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;

namespace EShift_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();

            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.SetBasePath(Directory.GetCurrentDirectory())
                           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
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

                    services.AddSingleton<Layout>();
                    services.AddTransient<CustomerForm>();
                    services.AddTransient<DriverForm>();
                    services.AddTransient<AssistantForm>();
                    services.AddTransient<LorryForm>();
                })
                .Build();

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
            else
            {
                MessageBox.Show("Database connection successful!", "Connection Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var mdiForm = host.Services.GetRequiredService<Layout>();
            Application.Run(mdiForm);
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