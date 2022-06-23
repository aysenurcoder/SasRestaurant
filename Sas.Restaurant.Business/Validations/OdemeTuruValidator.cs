using FluentValidation;
using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
    public class OdemeTuruValidator: AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Ödeme Adı 50 karakterden fazla olamaz.");
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Ödeme Adı boş geçilemez.");
        }
    }
}
