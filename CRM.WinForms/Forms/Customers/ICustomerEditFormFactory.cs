namespace CRM.WinForms.Forms.Customers;

/// <summary>
/// Creates <see cref="CustomerEditForm"/> instances for the presentation layer.
/// Lets callers open the edit form with an optional customer id without
/// resolving dependencies from the DI container themselves.
/// </summary>
public interface ICustomerEditFormFactory
{
    CustomerEditForm Create(int? customerId = null);
}
