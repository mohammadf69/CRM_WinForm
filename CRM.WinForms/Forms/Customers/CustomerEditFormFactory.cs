using CRM.Application.Interfaces;

namespace CRM.WinForms.Forms.Customers;

public sealed class CustomerEditFormFactory : ICustomerEditFormFactory
{
    private readonly ICustomerService _customerService;
    private readonly ICompanyService _companyService;

    public CustomerEditFormFactory(
        ICustomerService customerService,
        ICompanyService companyService)
    {
        _customerService = customerService;
        _companyService = companyService;
    }

    public CustomerEditForm Create(int? customerId = null)
    {
        return new CustomerEditForm(
            _customerService,
            _companyService,
            customerId);
    }
}
