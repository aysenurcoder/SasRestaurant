using FluentValidation;
using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
    public class AdresValidator : AbstractValidator<Adres>
    {
        public AdresValidator()
        {
            RuleFor(c => c.Il).MaximumLength(30).WithMessage("Il bilgisi 20 karakterden fazla olamaz.");
            RuleFor(c => c.Ilce).MaximumLength(30).WithMessage("Ilce bilgisi 20 karakterden fazla olamaz.");

        }
    }
}
