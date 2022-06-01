using FluentValidation;
using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
    public class MasaValidator : AbstractValidator<Masa>
    {
        public MasaValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Masa adı 50 karakterden fazla olamaz.");
        }
    }
}
