using Sas.Restaurant.Entities.Enums;
using Sas.Restaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entities.Tables
{
    public class Kullanici:EntityBase
    {
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public KullaniciRol KullaniciRol { get; set; }
    }
}
