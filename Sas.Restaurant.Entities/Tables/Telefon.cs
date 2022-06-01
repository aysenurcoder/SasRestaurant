using Sas.Restaurant.Entities.Enums;
using Sas.Restaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entities.Tables
{
    public class Telefon:EntityBase
    {
        public TelefonAdresTip TelefonTip { get; set; }
        public string Telefonu { get; set; }
        public Guid MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
