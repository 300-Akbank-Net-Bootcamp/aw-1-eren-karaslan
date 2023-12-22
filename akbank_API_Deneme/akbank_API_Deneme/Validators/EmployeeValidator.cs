using akbank_API_Deneme.Controllers;
using FluentValidation;

namespace akbank_API_Deneme.Validators;

public class EmployeeValidator : AbstractValidator<Employee>
{
    public EmployeeValidator()
    {
        RuleFor(x => x.Name).Length(10, 250).WithMessage("Invalid Name")
            .NotNull().WithMessage("Boş bırakmayınız");

        RuleFor(x => x.Email).EmailAddress().WithMessage("Email address is not valid.");

        RuleFor(x => x.Phone).Length(10, 11).WithMessage("Phone is not valid.");

        RuleFor(x => x.HourlySalary).GreaterThan(50).WithMessage("Hourly salary does not fall within allowed range.")
                                    .LessThan(400).WithMessage("Hourly salary does not fall within allowed range.");

        RuleFor(x => x.DateOfBirth).GreaterThan(DateTime.Today.AddYears(-65)).WithMessage("Birthdate is not valid.");   
    }

}