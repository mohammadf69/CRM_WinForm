using CRM.Application.DTOs.Customers;
using FluentValidation;

namespace CRM.Application.Validators.Customers;

public class UpdateCustomerValidator : AbstractValidator<UpdateCustomerDto>

{
    public UpdateCustomerValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MaximumLength(100)
            .WithMessage("نام الزامی است و حداکثر 10 کاراکتر است.");

        RuleFor(x => x.LastName)
            .NotEmpty()
            .MaximumLength(100)
            .WithMessage("نام خانوادگی الزامی است و حداکثر 20 کاراکتر است.");

        RuleFor(x => x.NationalCode)
            .Length(10)
            .When(x => !string.IsNullOrWhiteSpace(x.NationalCode))
            .WithMessage("کد ملی باید 10 رقم باشد.");

        RuleFor(x => x.Mobile)
            .MaximumLength(20).MinimumLength(1)
            .WithMessage("شماره موبایل نمی‌تواند بیشتر از 11 کاراکتر باشد.");

        RuleFor(x => x.Email)
            .EmailAddress()
            .When(x => string.IsNullOrWhiteSpace(x.Email))
            .WithMessage("ایمیل معتبر نیست.");
    }
}