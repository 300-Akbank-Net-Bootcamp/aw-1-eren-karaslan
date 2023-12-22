using akbank_API_Deneme.Controllers;
using FluentValidation;

namespace akbank_API_Deneme.Validators;


public class StaffValidator : AbstractValidator<Staff>
{
    public StaffValidator()
    {
        RuleFor(x => x.Name).Length(10, 250)
            .NotNull().WithMessage("Boş bırakmayınız");

        RuleFor(x => x.Email).EmailAddress().WithMessage("Email address is not valid.");

        RuleFor(x => x.Phone).Length(10, 11).WithMessage("Phone is not Valid");

        RuleFor(x => x.HourlySalary).LessThan(400).GreaterThan(30).WithMessage("Hourly salary does not fall within allowed range.");
    }
}
