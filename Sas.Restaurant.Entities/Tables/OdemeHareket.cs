using Sas.Restaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entities.Tables
{
    public class OdemeHareket : EntityBase
    {
        public decimal Tutar { get; set; }
        public Guid OdemeTuruId { get; set; }
        public virtual OdemeTuru OdemeTuru { get; set; }
        public Guid AdisyonId { get; set; }
        public virtual Adisyon Adisyon { get; set; }
    }
}
