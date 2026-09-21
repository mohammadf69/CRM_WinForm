using CRM.Application.Interfaces;
using CRM.Application.Validators.Customers;
using CRM.Infrastructure.Data;
using CRM.Infrastructure.Services;
using CRM.WinForms.Forms.Customers;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

        // Developer-local, untracked overrides (may contain the local
        // connection string with credentials). See .gitignore.
        builder.Configuration.AddJsonFile(
            "appsettings.Development.json",
            optional: true,
            reloadOnChange: true);

        var connectionString =
            builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException(
                "Connection string 'DefaultConnection' not found.");

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        builder.Services.AddScoped<ICustomerService, CustomerService>();
        builder.Services.AddScoped<ICompanyService, CompanyService>();
        builder.Services.AddValidatorsFromAssemblyContaining<CreateCustomerValidator>();

        builder.Services.AddTransient<CustomerListForm>();
        builder.Services.AddTransient<Form1>();

        // Forms receive factories/delegates instead of the service container,
        // so no form resolves its own dependencies at runtime.
        builder.Services.AddTransient<ICustomerEditFormFactory, CustomerEditFormFactory>();
        builder.Services.AddTransient<Func<CustomerListForm>>(serviceProvider =>
            () => serviceProvider.GetRequiredService<CustomerListForm>());

        using var host = builder.Build();

        var mainForm = host.Services.GetRequiredService<Form1>();

        System.Windows.Forms.Application.Run(mainForm);
    }
}