using CRM.Application.DTOs.Customers;
using CRM.Application.Interfaces;
using CRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CRM.Infrastructure.Services;

public class CustomerService : ICustomerService
{
    private readonly AppDbContext _context;

    public CustomerService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<CustomerListDto>> GetAllAsync()
    {
        return await _context.Customers
            .AsNoTracking()
            .Select(x => new CustomerListDto
            {
                Id = x.Id,

                FullName = x.FirstName + " " + x.LastName,

                Mobile = x.Mobile,

                CompanyName = x.Company != null
                    ? x.Company.Name
                    : null,

                IsActive = x.IsActive,

                InteractionCount = x.Interactions.Count(),

                FollowUpCount = x.FollowUps.Count()
            })
            .ToListAsync();
    }

    public async Task<List<CustomerListDto>> SearchAsync(string search)
    {
        return await _context.Customers
            .AsNoTracking()
            .Where(x =>
                x.FirstName.Contains(search) ||
                x.LastName.Contains(search) ||
                (x.Mobile != null && x.Mobile.Contains(search)))
            .Select(x => new CustomerListDto
            {
                Id = x.Id,

                FullName = x.FirstName + " " + x.LastName,

                Mobile = x.Mobile,

                CompanyName = x.Company != null
                    ? x.Company.Name
                    : null,

                IsActive = x.IsActive,

                InteractionCount = x.Interactions.Count(),

                FollowUpCount = x.FollowUps.Count()
            })
            .ToListAsync();
    }
    public async Task CreateAsync(CreateCustomerDto dto)
    {
        var customer = new Customer
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            NationalCode = dto.NationalCode,
            Mobile = dto.Mobile,
            Phone = dto.Phone,
            Email = dto.Email,
            Address = dto.Address,
            CompanyId = dto.CompanyId,
            AssignedUserId = dto.AssignedUserId,
            IsActive = true,
            CreatedAt = DateTime.UtcNow
        };

        _context.Customers.Add(customer);

        await _context.SaveChangesAsync();
    }
}