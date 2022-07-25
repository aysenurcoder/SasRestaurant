using DevExpress.XtraEditors;
using Sas.Restaurant.Components.CallerId;
using Sas.Restaurant.UI.BackOffice.Musteri;
using Sas.Restaurant.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.UI.BackOffice.AnaMenu
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            controlKullaniciGiris1.KullaniciKontrolEvent += KullaniciGirisKontrol;
            controlKullaniciGiris1.KapatButton += KapatButton;
        }

        private void KapatButton()
        {
            MessageBox.Show("Kapatıldı");
        }

        private void KullaniciGirisKontrol(object sender, KullaniciKontrolEventArgs e)
        {
            if (e.Kullanici==null)
            {
                MessageBox.Show("Hatalı Kullanıcı");
            }
            else
            {
                MessageBox.Show("Kullanıcı girişi başarılı");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            controlBadgeButton1.Count++;
        }

       
    }
}