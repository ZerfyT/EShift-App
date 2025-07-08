using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EShift_App.Data;
using EShift_App.Data.Repositories;

namespace EShift_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
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
                    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

                services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                services.AddScoped<ICustomerRepository, CustomerRepository>();
                // ... register other repositories here

                // 3. Register Forms
                services.AddTransient<CustomersForm>();
            })
            .Build();

            // Get the main form from the service provider and run it
            var mainForm = host.Services.GetRequiredService<CustomersForm>();


            Application.Run(mainForm);
        }
    }
}