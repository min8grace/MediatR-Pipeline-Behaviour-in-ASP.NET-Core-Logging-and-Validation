using CqrsPattern.Features.Product.Command;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsPattern.Validators
{
    public class CreateProductCommndValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommndValidator()
        {
            RuleFor(c => c.Barcode).NotEmpty();
            RuleFor(c => c.Name).NotEmpty();
        }
    }
}
