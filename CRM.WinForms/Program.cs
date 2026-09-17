using CRM.Application.Interfaces;
using CRM.Infrastructure.Data;
using CRM.Infrastructure.Services;
using CRM.WinForms.Forms.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static System.Net.Mime.MediaTypeNames;

namespace CRM.WinForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
       

        var builder = Host.CreateApplicationBuilder();

        builder.Configuration.AddJsonFile(
            "appsettings.json",
            optional: false,
            reloadOnChange: true);

        var connectionString =
            builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException(
                "Connection string 'DefaultConnection' not found.");

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        builder.Services.AddScoped<ICustomerService, CustomerService>();
        builder.Services.AddTransient<CustomerListForm>();
        builder.Services.AddTransient<CustomerEditForm>();
        builder.Services.AddTransient<Form1>();

        using var host = builder.Build();

        var mainForm = host.Services.GetRequiredService<Form1>();

        System.Windows.Forms.Application.Run(mainForm);
    }
}