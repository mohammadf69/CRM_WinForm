using CRM.Application.DTOs.Customers;

namespace CRM.Application.Interfaces;

public interface ICustomerService
{
    Task<List<CustomerListDto>> GetAllAsync();

    Task<List<CustomerListDto>> SearchAsync(string search);
    Task CreateAsync(CreateCustomerDto dto);
    Task<CustomerEditDto?> GetByIdAsync(int id);

    Task UpdateAsync(UpdateCustomerDto dto);

    Task DeleteAsync(int id);
}