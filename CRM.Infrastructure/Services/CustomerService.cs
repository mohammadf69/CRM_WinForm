using CRM.Application.DTOs.Customers;
using CRM.Application.Interfaces;
using CRM.Infrastructure.Data;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace CRM.Infrastructure.Services;

public class CustomerService : ICustomerService
{
    private readonly AppDbContext _context;
    private readonly IValidator<CreateCustomerDto> _createValidator;
    public CustomerService(AppDbContext context, IValidator<CreateCustomerDto> createValidator)
    {
        _context = context;
        _createValidator =createValidator;
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
        var validationResult =
            await _createValidator.ValidateAsync(dto);

        if (!validationResult.IsValid)
        {
            var errors = string.Join(
                Environment.NewLine,
                validationResult.Errors.Select(x => x.ErrorMessage));

            throw new ValidationException(errors);
        }

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

    public async Task<CustomerEditDto?> GetByIdAsync(int id)
    {
        return await _context.Customers
            .AsNoTracking()
            .Where(x => x.Id == id)
            .Select(x => new CustomerEditDto
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                NationalCode = x.NationalCode,
                Mobile = x.Mobile,
                Phone = x.Phone,
                Email = x.Email,
                Address = x.Address,
                CompanyId = x.CompanyId,
                AssignedUserId = x.AssignedUserId,
                IsActive = x.IsActive
            })
            .FirstOrDefaultAsync();
    }
    public async Task UpdateAsync(UpdateCustomerDto dto)
    {
        //var validationResult =
        //    await _createValidator.ValidateAsync(dto);
        //if (!validationResult.IsValid)
        //{
        //    var errors = string.Join(
        //        Environment.NewLine,
        //        validationResult.Errors.Select(x => x.ErrorMessage));

        //    throw new ValidationException(errors);
        //}
        var customer = await _context.Customers
            .FirstOrDefaultAsync(x => x.Id == dto.Id);

        if (customer is null)
            throw new KeyNotFoundException("مشتری مورد نظر موجود  نمی باشد");

        customer.FirstName = dto.FirstName;
        customer.LastName = dto.LastName;
        customer.NationalCode = dto.NationalCode;
        customer.Mobile = dto.Mobile;
        customer.Phone = dto.Phone;
        customer.Email = dto.Email;
        customer.Address = dto.Address;
        customer.CompanyId = dto.CompanyId;
        customer.AssignedUserId = dto.AssignedUserId;
        customer.IsActive = dto.IsActive;
        customer.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var customer = await _context.Customers
            .FirstOrDefaultAsync(x => x.Id == id);

        if (customer is null)
            throw new KeyNotFoundException("مشتری مورد نظر موجود  نمی باشد");

        _context.Customers.Remove(customer);

        await _context.SaveChangesAsync();
    }
}