using BlazorFluentValidationComplex.Data;
using FluentValidation;

namespace BlazorFluentValidationComplex.Validation
{
    public class ParentViewModelValidator : AbstractValidator<ParentViewModel>
    {
        public ParentViewModelValidator()
        {
            RuleFor(c => c.Parent.Name).NotEmpty();

            RuleFor(c => c.Parent.Children[1].DataValue).NotEmpty(); // force second element in array to be required just for complexity
        }
    }
}