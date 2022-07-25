using Sas.Restaurant.Entities.Enums;
using Sas.Restaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entities.Tables
{
    public class Musteri:EntityBase
    {
        public MusteriTip MusteriTip { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sirket { get; set; }
        public string KartNo { get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }
        public virtual ICollection<Adres> Adresler { get; set; }
        public virtual ICollection<Adisyon> Adisyonlar { get; set; }
        public virtual ICollection<AramaKaydi> AramaKayitlari { get; set; }
    }
}
