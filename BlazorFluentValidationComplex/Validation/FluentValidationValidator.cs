using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;

namespace BlazorFluentValidationComplex.Validation
{
    public class FluentValidationValidator : ComponentBase
    {
        [CascadingParameter] private EditContext CurrentEditContext { get; set; }

        protected override void OnInit()
        {
            if (CurrentEditContext == null)
            {
                throw new InvalidOperationException($"{nameof(FluentValidationValidator)} requires a cascading " +
                    $"parameter of type {nameof(EditContext)}. For example, you can use {nameof(FluentValidationValidator)} " +
                    $"inside an {nameof(EditForm)}.");
            }

            CurrentEditContext.AddFluentValidation();
        }
    }
}