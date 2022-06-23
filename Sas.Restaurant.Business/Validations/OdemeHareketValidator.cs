using FluentValidation;
using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
    class OdemeHareketValidator : AbstractValidator<OdemeHareket>
    {
        public OdemeHareketValidator()
        {
            RuleFor(c => c.Tutar).ScalePrecision(2, 10);
        } 
    }
}
