using DevExpress.XtraEditors;
using Sas.Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.UserControls
{
    public class ControlKategoriButton: CheckButton
    {
        public Guid Id { get; set; }
        public IEnumerable<Urun> Urunler { get; set; }
    }
}
