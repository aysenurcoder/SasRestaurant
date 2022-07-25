using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.UserControls
{
    public class KullaniciKontrolEventArgs:EventArgs
    {
        public Kullanici Kullanici { get; set; }
    }
}
