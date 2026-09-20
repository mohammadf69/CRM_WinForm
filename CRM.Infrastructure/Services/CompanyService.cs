using CRM.Application.DTOs.Companies;
using CRM.Application.Interfaces;
using CRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CRM.Infrastructure.Services;

public class CompanyService : ICompanyService
{
    private readonly AppDbContext _context;

    public CompanyService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<CompanyLookupDto>> GetAllAsync()
    {
        return await _context.Companies
            .AsNoTracking()
            .OrderBy(x => x.Name)
            .Select(x => new CompanyLookupDto
            {
                Id = x.Id,
                Name = x.Name
            })
            .ToListAsync();
    }
}