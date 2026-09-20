using CRM.Application.DTOs.Companies;

namespace CRM.Application.Interfaces;

public interface ICompanyService
{
    Task<List<CompanyLookupDto>> GetAllAsync();
}