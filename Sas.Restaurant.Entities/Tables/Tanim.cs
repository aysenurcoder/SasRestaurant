using Sas.Restaurant.Entities.Enums;
using Sas.Restaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entities.Tables
{
    public class Tanim:EntityBase
    {
        public string Adi { get; set; }
        public TanimTip TanimTip { get; set; }
    }
}
