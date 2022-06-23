
namespace Sas.Restaurant.UserControls
{
    partial class ControlMenuKayit
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMenuKayit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutItemVazgeç = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemKapat = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemSil = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemDuzenle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemEkle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemSec = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemKaydet = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemVazgeç)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemKaydet)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnKaydet);
            this.layoutControl1.Controls.Add(this.btnSec);
            this.layoutControl1.Controls.Add(this.btnEkle);
            this.layoutControl1.Controls.Add(this.btnDuzenle);
            this.layoutControl1.Controls.Add(this.btnSil);
            this.layoutControl1.Controls.Add(this.btnKapat);
            this.layoutControl1.Controls.Add(this.btnVazgec);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(841, 0, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1074, 91);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(616, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKaydet.Size = new System.Drawing.Size(150, 87);
            this.btnKaydet.StyleController = this.layoutControl1;
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSec
            // 
            this.btnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.ImageOptions.Image")));
            this.btnSec.Location = new System.Drawing.Point(2, 2);
            this.btnSec.Name = "btnSec";
            this.btnSec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSec.Size = new System.Drawing.Size(150, 87);
            this.btnSec.StyleController = this.layoutControl1;
            this.btnSec.TabIndex = 9;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(156, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEkle.Size = new System.Drawing.Size(149, 87);
            this.btnEkle.StyleController = this.layoutControl1;
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(309, 2);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDuzenle.Size = new System.Drawing.Size(150, 87);
            this.btnDuzenle.StyleController = this.layoutControl1;
            this.btnDuzenle.TabIndex = 7;
            this.btnDuzenle.Text = "Duzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(463, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSil.Size = new System.Drawing.Size(149, 87);
            this.btnSil.StyleController = this.layoutControl1;
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(922, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(150, 87);
            this.btnKapat.StyleController = this.layoutControl1;
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.ImageOptions.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(770, 2);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnVazgec.Size = new System.Drawing.Size(148, 87);
            this.btnVazgec.StyleController = this.layoutControl1;
            this.btnVazgec.TabIndex = 4;
            this.btnVazgec.Text = "vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutItemVazgeç,
            this.layoutItemKapat,
            this.layoutItemSil,
            this.layoutItemDuzenle,
            this.layoutItemEkle,
            this.layoutItemSec,
            this.layoutItemKaydet});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1074, 91);
            this.Root.TextVisible = false;
            // 
            // layoutItemVazgeç
            // 
            this.layoutItemVazgeç.Control = this.btnVazgec;
            this.layoutItemVazgeç.Location = new System.Drawing.Point(768, 0);
            this.layoutItemVazgeç.MinSize = new System.Drawing.Size(50, 31);
            this.layoutItemVazgeç.Name = "layoutItemVazgeç";
            this.layoutItemVazgeç.Size = new System.Drawing.Size(152, 91);
            this.layoutItemVazgeç.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemVazgeç.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemVazgeç.TextVisible = false;
            // 
            // layoutItemKapat
            // 
            this.layoutItemKapat.Control = this.btnKapat;
            this.layoutItemKapat.Location = new System.Drawing.Point(920, 0);
            this.layoutItemKapat.MinSize = new System.Drawing.Size(43, 31);
            this.layoutItemKapat.Name = "layoutItemKapat";
            this.layoutItemKapat.Size = new System.Drawing.Size(154, 91);
            this.layoutItemKapat.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemKapat.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemKapat.TextVisible = false;
            // 
            // layoutItemSil
            // 
            this.layoutItemSil.Control = this.btnSil;
            this.layoutItemSil.Location = new System.Drawing.Point(461, 0);
            this.layoutItemSil.MinSize = new System.Drawing.Size(25, 31);
            this.layoutItemSil.Name = "layoutItemSil";
            this.layoutItemSil.Size = new System.Drawing.Size(153, 91);
            this.layoutItemSil.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemSil.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemSil.TextVisible = false;
            // 
            // layoutItemDuzenle
            // 
            this.layoutItemDuzenle.Control = this.btnDuzenle;
            this.layoutItemDuzenle.Location = new System.Drawing.Point(307, 0);
            this.layoutItemDuzenle.MinSize = new System.Drawing.Size(56, 31);
            this.layoutItemDuzenle.Name = "layoutItemDuzenle";
            this.layoutItemDuzenle.Size = new System.Drawing.Size(154, 91);
            this.layoutItemDuzenle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemDuzenle.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemDuzenle.TextVisible = false;
            // 
            // layoutItemEkle
            // 
            this.layoutItemEkle.Control = this.btnEkle;
            this.layoutItemEkle.Location = new System.Drawing.Point(154, 0);
            this.layoutItemEkle.MinSize = new System.Drawing.Size(34, 31);
            this.layoutItemEkle.Name = "layoutItemEkle";
            this.layoutItemEkle.Size = new System.Drawing.Size(153, 91);
            this.layoutItemEkle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemEkle.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemEkle.TextVisible = false;
            // 
            // layoutItemSec
            // 
            this.layoutItemSec.Control = this.btnSec;
            this.layoutItemSec.Location = new System.Drawing.Point(0, 0);
            this.layoutItemSec.MinSize = new System.Drawing.Size(32, 31);
            this.layoutItemSec.Name = "layoutItemSec";
            this.layoutItemSec.Size = new System.Drawing.Size(154, 91);
            this.layoutItemSec.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemSec.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemSec.TextVisible = false;
            // 
            // layoutItemKaydet
            // 
            this.layoutItemKaydet.Control = this.btnKaydet;
            this.layoutItemKaydet.Location = new System.Drawing.Point(614, 0);
            this.layoutItemKaydet.MinSize = new System.Drawing.Size(49, 31);
            this.layoutItemKaydet.Name = "layoutItemKaydet";
            this.layoutItemKaydet.Size = new System.Drawing.Size(154, 91);
            this.layoutItemKaydet.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemKaydet.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemKaydet.TextVisible = false;
            // 
            // ControlMenuKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ControlMenuKayit";
            this.Size = new System.Drawing.Size(1074, 91);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemVazgeç)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemKaydet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemVazgeç;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemKapat;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemSil;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemDuzenle;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemEkle;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemSec;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemKaydet;
    }
}
