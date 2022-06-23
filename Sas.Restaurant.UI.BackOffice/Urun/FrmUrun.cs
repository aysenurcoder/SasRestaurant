using DevExpress.XtraEditors;
using Sas.Restaurant.Business.Workers;
using Sas.Restaurant.UI.BackOffice.Fotograf;
using Sas.Restaurant.Core.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sas.Restaurant.UI.BackOffice.Urun
{
    public partial class FrmUrun : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new Business.Workers.RestaurantWorker();
        public FrmUrun()
        {
            InitializeComponent();
            Listele();
        }

        void Listele()
        {
            worker.UrunService.Load(null,c=>c.UrunGrup);
            gridControlUrunler.DataSource = worker.UrunService.BindingList();
        }


        private void controlMenu_ButtonEkle(object sender, EventArgs e)
        {
            FrmUrunIslem form = new FrmUrunIslem(new Entities.Tables.Urun());
            form.ShowDialog();
            if (form.Eklendi)
            {
                Listele();
            }
        }

        private void controlMenu_ButtonDuzenle(object sender, EventArgs e)
        {
            if (gridUrunler.GetFocusedRow() == null)
            {
                return;
            }
            FrmUrunIslem form = new FrmUrunIslem((Entities.Tables.Urun)gridUrunler.GetFocusedRow());
            form.ShowDialog();
            if (form.Eklendi)
            {
                Listele();
            }
        }

        private void controlMenu_ButtonSil(object sender, EventArgs e)
        {
            if (gridUrunler.GetFocusedRow() == null)
            {
                return;
            }
            if (MessageBox.Show("Seçili olan veriyi silmek ister misiniz?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                gridUrunler.DeleteSelectedRows();
                Listele();
            }
            
            
        }

        private void controlMenu_ButtonGuncelle(object sender, EventArgs e)
        {
            Listele();
        }

        private void controlMenu_ButtonKapat(object sender, EventArgs e)
        {
            Close();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnFotografEkle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Entities.Tables.Urun entity = (Entities.Tables.Urun)gridUrunler.GetFocusedRow();
            FrmImageEditor form = new FrmImageEditor();
            form.ShowDialog();
            if (form.ReturnedImage!=null)
            {
                entity.Fotograf = form.ReturnedImage.ImageToByteArray();
                worker.Commit();
                gridUrunler.RefreshData();
            }
        }
    }
}