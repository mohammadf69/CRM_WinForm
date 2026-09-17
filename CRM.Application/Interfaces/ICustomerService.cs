using CRM.Application.DTOs.Customers;

namespace CRM.Application.Interfaces;

public interface ICustomerService
{
    Task<List<CustomerListDto>> GetAllAsync();

    Task<List<CustomerListDto>> SearchAsync(string search);
    Task CreateAsync(CreateCustomerDto dto);
}