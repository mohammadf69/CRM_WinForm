using CRM.Application.DTOs.Customers;
using FluentValidation;

namespace CRM.Application.Validators.Customers;

public class CreateCustomerValidator : AbstractValidator<CreateCustomerDto>
{
    public CreateCustomerValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("نام الزامی است.")
            .MaximumLength(100)
            .WithMessage("نام نمی‌تواند بیشتر از 100 کاراکتر باشد.");

        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("نام خانوادگی الزامی است.")
            .MaximumLength(100)
            .WithMessage("نام خانوادگی نمی‌تواند بیشتر از 100 کاراکتر باشد.");

        RuleFor(x => x.Mobile)
            .MaximumLength(11)
            .When(x => !string.IsNullOrWhiteSpace(x.Mobile))
            .WithMessage("شماره موبایل نمی‌تواند بیشتر از 11 کاراکتر باشد.");

        RuleFor(x => x.Email)
            .EmailAddress()
            .When(x => !string.IsNullOrWhiteSpace(x.Email))
            .WithMessage("ایمیل معتبر نیست.");

        RuleFor(x => x.NationalCode)
            .Length(10)
            .When(x => !string.IsNullOrWhiteSpace(x.NationalCode))
            .WithMessage("کد ملی باید 10 رقم باشد.");

    }
}