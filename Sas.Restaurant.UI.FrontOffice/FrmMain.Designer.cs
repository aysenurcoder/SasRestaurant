
namespace Sas.Restaurant.UI.FrontOffice
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnMusteri = new Sas.Restaurant.UserControls.ControlMusteriButton();
            this.btnGarsonSecim = new Sas.Restaurant.UserControls.ControlGarsonButton();
            this.btnKategoriyeDon = new DevExpress.XtraEditors.SimpleButton();
            this.navigationMain = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageMasalar = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupMasalar = new DevExpress.XtraEditors.GroupControl();
            this.flowMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.groupKonumlar = new DevExpress.XtraEditors.GroupControl();
            this.flowKonum = new System.Windows.Forms.FlowLayoutPanel();
            this.pageAdisyonAyrinti = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelUrunHareketHizliSatis = new DevExpress.XtraEditors.PanelControl();
            this.navigationKategori = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageKategoriUrunler = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowKategoriUrunleri = new System.Windows.Forms.FlowLayoutPanel();
            this.pageUrunPorsiyon = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowPoriyon = new System.Windows.Forms.FlowLayoutPanel();
            this.pageEkMalzeme = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowEkMalzeme = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtEkMalzemeTutar = new DevExpress.XtraEditors.CalcEdit();
            this.txtToplamTutar = new DevExpress.XtraEditors.CalcEdit();
            this.txtPorsiyonTutar = new DevExpress.XtraEditors.CalcEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnEkMalzemeOnay = new DevExpress.XtraEditors.SimpleButton();
            this.pageGarson = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowGarson = new System.Windows.Forms.FlowLayoutPanel();
            this.pageMusteri = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowMusteri = new System.Windows.Forms.FlowLayoutPanel();
            this.pageOdemeEkranı = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlOdeme = new DevExpress.XtraGrid.GridControl();
            this.gridOdeme = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.txtKalanTutar = new DevExpress.XtraEditors.CalcEdit();
            this.txtOdenenTutar = new DevExpress.XtraEditors.CalcEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.flowOdemeTurleri = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUrunGrupKeypad = new DevExpress.XtraEditors.PanelControl();
            this.groupKategori = new DevExpress.XtraEditors.GroupControl();
            this.flowKategori = new System.Windows.Forms.FlowLayoutPanel();
            this.groupKeypad = new DevExpress.XtraEditors.GroupControl();
            this.txtMiktar = new DevExpress.XtraEditors.CalcEdit();
            this.btnKeypadOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnKeypadDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnKeypadBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnVirgul = new DevExpress.XtraEditors.SimpleButton();
            this.btnBir = new DevExpress.XtraEditors.SimpleButton();
            this.btnSekiz = new DevExpress.XtraEditors.SimpleButton();
            this.btnDokuz = new DevExpress.XtraEditors.SimpleButton();
            this.btnUc = new DevExpress.XtraEditors.SimpleButton();
            this.btnSifir = new DevExpress.XtraEditors.SimpleButton();
            this.btnIki = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlti = new DevExpress.XtraEditors.SimpleButton();
            this.btnBes = new DevExpress.XtraEditors.SimpleButton();
            this.btnDort = new DevExpress.XtraEditors.SimpleButton();
            this.btnYedi = new DevExpress.XtraEditors.SimpleButton();
            this.panelUrunHareket = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colHareketTip = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_6 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colMiktar = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBirimi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBirimFiyat = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colToplam = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colAciklama = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.item2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.item5 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.item6 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnIndirim = new DevExpress.XtraEditors.SimpleButton();
            this.btnBol = new DevExpress.XtraEditors.SimpleButton();
            this.btnIade = new DevExpress.XtraEditors.SimpleButton();
            this.btnMiktarAzalt = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtUrunHareketIndirimTutar = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunHareketOdenecekTutar = new DevExpress.XtraEditors.CalcEdit();
            this.txtToplamUrunHareketTutar = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelUrunHareketMenu = new DevExpress.XtraEditors.PanelControl();
            this.btnEkMalzeme = new DevExpress.XtraEditors.SimpleButton();
            this.btnIkram = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiyatDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnMiktarArttir = new DevExpress.XtraEditors.SimpleButton();
            this.panelHareketSolMenu = new DevExpress.XtraEditors.PanelControl();
            this.btnSiparisKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdisyonDetay = new DevExpress.XtraEditors.SimpleButton();
            this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeEkle = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtOdemeTutari = new DevExpress.XtraEditors.CalcEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationMain)).BeginInit();
            this.navigationMain.SuspendLayout();
            this.pageMasalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMasalar)).BeginInit();
            this.groupMasalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupKonumlar)).BeginInit();
            this.groupKonumlar.SuspendLayout();
            this.pageAdisyonAyrinti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelUrunHareketHizliSatis)).BeginInit();
            this.panelUrunHareketHizliSatis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationKategori)).BeginInit();
            this.navigationKategori.SuspendLayout();
            this.pageKategoriUrunler.SuspendLayout();
            this.pageUrunPorsiyon.SuspendLayout();
            this.pageEkMalzeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkMalzemeTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorsiyonTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.pageGarson.SuspendLayout();
            this.pageMusteri.SuspendLayout();
            this.pageOdemeEkranı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKalanTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdenenTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUrunGrupKeypad)).BeginInit();
            this.panelUrunGrupKeypad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupKategori)).BeginInit();
            this.groupKategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupKeypad)).BeginInit();
            this.groupKeypad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUrunHareket)).BeginInit();
            this.panelUrunHareket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunHareketIndirimTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunHareketOdenecekTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamUrunHareketTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUrunHareketMenu)).BeginInit();
            this.panelUrunHareketMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHareketSolMenu)).BeginInit();
            this.panelHareketSolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTutari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnMusteri);
            this.panelControl1.Controls.Add(this.btnGarsonSecim);
            this.panelControl1.Controls.Add(this.btnKategoriyeDon);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1477, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // btnMusteri
            // 
            this.btnMusteri.Adi = null;
            this.btnMusteri.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.Appearance.Options.UseFont = true;
            this.btnMusteri.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMusteri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteri.ImageOptions.Image")));
            this.btnMusteri.Location = new System.Drawing.Point(925, 2);
            this.btnMusteri.MusteriId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.btnMusteri.MusteriTip = Sas.Restaurant.Entities.Enums.MusteriTip.Yok;
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(222, 40);
            this.btnMusteri.Soyadi = null;
            this.btnMusteri.TabIndex = 2;
            this.btnMusteri.Text = "Müşteri Seçilmedi";
            this.btnMusteri.Visible = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnGarsonSecim
            // 
            this.btnGarsonSecim.Adi = null;
            this.btnGarsonSecim.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGarsonSecim.Appearance.Options.UseFont = true;
            this.btnGarsonSecim.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGarsonSecim.GarsonId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.btnGarsonSecim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGarsonSecim.ImageOptions.Image")));
            this.btnGarsonSecim.Location = new System.Drawing.Point(1147, 2);
            this.btnGarsonSecim.Name = "btnGarsonSecim";
            this.btnGarsonSecim.Size = new System.Drawing.Size(222, 40);
            this.btnGarsonSecim.Soyadi = null;
            this.btnGarsonSecim.TabIndex = 1;
            this.btnGarsonSecim.Text = "Garson Seçilmedi";
            this.btnGarsonSecim.Visible = false;
            this.btnGarsonSecim.Click += new System.EventHandler(this.btnGarsonSecim_Click);
            // 
            // btnKategoriyeDon
            // 
            this.btnKategoriyeDon.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriyeDon.Appearance.Options.UseFont = true;
            this.btnKategoriyeDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKategoriyeDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKategoriyeDon.ImageOptions.Image")));
            this.btnKategoriyeDon.Location = new System.Drawing.Point(1369, 2);
            this.btnKategoriyeDon.Name = "btnKategoriyeDon";
            this.btnKategoriyeDon.Size = new System.Drawing.Size(106, 40);
            this.btnKategoriyeDon.TabIndex = 0;
            this.btnKategoriyeDon.Text = "Geri Dön";
            this.btnKategoriyeDon.Visible = false;
            this.btnKategoriyeDon.Click += new System.EventHandler(this.btnKategoriyeDon_Click);
            // 
            // navigationMain
            // 
            this.navigationMain.Controls.Add(this.pageMasalar);
            this.navigationMain.Controls.Add(this.pageAdisyonAyrinti);
            this.navigationMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationMain.Location = new System.Drawing.Point(0, 44);
            this.navigationMain.Name = "navigationMain";
            this.navigationMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageMasalar,
            this.pageAdisyonAyrinti});
            this.navigationMain.SelectedPage = this.pageAdisyonAyrinti;
            this.navigationMain.Size = new System.Drawing.Size(1477, 723);
            this.navigationMain.TabIndex = 1;
            this.navigationMain.Text = "navigationFrame1";
            // 
            // pageMasalar
            // 
            this.pageMasalar.Caption = "pageMasalar";
            this.pageMasalar.Controls.Add(this.groupMasalar);
            this.pageMasalar.Controls.Add(this.groupKonumlar);
            this.pageMasalar.Name = "pageMasalar";
            this.pageMasalar.Size = new System.Drawing.Size(1477, 723);
            // 
            // groupMasalar
            // 
            this.groupMasalar.Controls.Add(this.flowMasalar);
            this.groupMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMasalar.Location = new System.Drawing.Point(0, 121);
            this.groupMasalar.Name = "groupMasalar";
            this.groupMasalar.Size = new System.Drawing.Size(1477, 602);
            this.groupMasalar.TabIndex = 2;
            this.groupMasalar.Text = "Masalar";
            // 
            // flowMasalar
            // 
            this.flowMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMasalar.Location = new System.Drawing.Point(2, 28);
            this.flowMasalar.Name = "flowMasalar";
            this.flowMasalar.Size = new System.Drawing.Size(1473, 572);
            this.flowMasalar.TabIndex = 1;
            // 
            // groupKonumlar
            // 
            this.groupKonumlar.Controls.Add(this.flowKonum);
            this.groupKonumlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupKonumlar.Location = new System.Drawing.Point(0, 0);
            this.groupKonumlar.Name = "groupKonumlar";
            this.groupKonumlar.Size = new System.Drawing.Size(1477, 121);
            this.groupKonumlar.TabIndex = 3;
            this.groupKonumlar.Text = "Konumlar";
            // 
            // flowKonum
            // 
            this.flowKonum.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowKonum.Location = new System.Drawing.Point(2, 28);
            this.flowKonum.Name = "flowKonum";
            this.flowKonum.Size = new System.Drawing.Size(1473, 94);
            this.flowKonum.TabIndex = 1;
            // 
            // pageAdisyonAyrinti
            // 
            this.pageAdisyonAyrinti.Caption = "pageAdisyonAyrinti";
            this.pageAdisyonAyrinti.Controls.Add(this.panelUrunHareketHizliSatis);
            this.pageAdisyonAyrinti.Controls.Add(this.panelUrunHareket);
            this.pageAdisyonAyrinti.Controls.Add(this.panelHareketSolMenu);
            this.pageAdisyonAyrinti.Name = "pageAdisyonAyrinti";
            this.pageAdisyonAyrinti.Size = new System.Drawing.Size(1477, 723);
            // 
            // panelUrunHareketHizliSatis
            // 
            this.panelUrunHareketHizliSatis.Controls.Add(this.navigationKategori);
            this.panelUrunHareketHizliSatis.Controls.Add(this.panelUrunGrupKeypad);
            this.panelUrunHareketHizliSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUrunHareketHizliSatis.Location = new System.Drawing.Point(672, 0);
            this.panelUrunHareketHizliSatis.Name = "panelUrunHareketHizliSatis";
            this.panelUrunHareketHizliSatis.Size = new System.Drawing.Size(805, 723);
            this.panelUrunHareketHizliSatis.TabIndex = 2;
            // 
            // navigationKategori
            // 
            this.navigationKategori.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navigationKategori.Controls.Add(this.pageKategoriUrunler);
            this.navigationKategori.Controls.Add(this.pageUrunPorsiyon);
            this.navigationKategori.Controls.Add(this.pageEkMalzeme);
            this.navigationKategori.Controls.Add(this.pageGarson);
            this.navigationKategori.Controls.Add(this.pageMusteri);
            this.navigationKategori.Controls.Add(this.pageOdemeEkranı);
            this.navigationKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationKategori.Location = new System.Drawing.Point(301, 2);
            this.navigationKategori.Name = "navigationKategori";
            this.navigationKategori.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageKategoriUrunler,
            this.pageUrunPorsiyon,
            this.pageEkMalzeme,
            this.pageGarson,
            this.pageMusteri,
            this.pageOdemeEkranı});
            this.navigationKategori.SelectedPage = this.pageKategoriUrunler;
            this.navigationKategori.Size = new System.Drawing.Size(502, 719);
            this.navigationKategori.TabIndex = 2;
            this.navigationKategori.Text = "navigationFrame2";
            // 
            // pageKategoriUrunler
            // 
            this.pageKategoriUrunler.Caption = "pageKategoriUrunler";
            this.pageKategoriUrunler.Controls.Add(this.flowKategoriUrunleri);
            this.pageKategoriUrunler.Name = "pageKategoriUrunler";
            this.pageKategoriUrunler.Size = new System.Drawing.Size(502, 719);
            // 
            // flowKategoriUrunleri
            // 
            this.flowKategoriUrunleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowKategoriUrunleri.Location = new System.Drawing.Point(0, 0);
            this.flowKategoriUrunleri.Name = "flowKategoriUrunleri";
            this.flowKategoriUrunleri.Size = new System.Drawing.Size(502, 719);
            this.flowKategoriUrunleri.TabIndex = 1;
            // 
            // pageUrunPorsiyon
            // 
            this.pageUrunPorsiyon.Caption = "pageUrunPorsiyon";
            this.pageUrunPorsiyon.Controls.Add(this.flowPoriyon);
            this.pageUrunPorsiyon.Name = "pageUrunPorsiyon";
            this.pageUrunPorsiyon.Size = new System.Drawing.Size(502, 719);
            // 
            // flowPoriyon
            // 
            this.flowPoriyon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPoriyon.Location = new System.Drawing.Point(0, 0);
            this.flowPoriyon.Name = "flowPoriyon";
            this.flowPoriyon.Size = new System.Drawing.Size(502, 719);
            this.flowPoriyon.TabIndex = 0;
            // 
            // pageEkMalzeme
            // 
            this.pageEkMalzeme.Caption = "pageEkMalzeme";
            this.pageEkMalzeme.Controls.Add(this.flowEkMalzeme);
            this.pageEkMalzeme.Controls.Add(this.panelControl3);
            this.pageEkMalzeme.Name = "pageEkMalzeme";
            this.pageEkMalzeme.Size = new System.Drawing.Size(502, 719);
            // 
            // flowEkMalzeme
            // 
            this.flowEkMalzeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowEkMalzeme.Location = new System.Drawing.Point(0, 0);
            this.flowEkMalzeme.Name = "flowEkMalzeme";
            this.flowEkMalzeme.Size = new System.Drawing.Size(502, 650);
            this.flowEkMalzeme.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.layoutControl1);
            this.panelControl3.Controls.Add(this.btnEkMalzemeOnay);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 650);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(502, 69);
            this.panelControl3.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtEkMalzemeTutar);
            this.layoutControl1.Controls.Add(this.txtToplamTutar);
            this.layoutControl1.Controls.Add(this.txtPorsiyonTutar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(405, 65);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtEkMalzemeTutar
            // 
            this.txtEkMalzemeTutar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtEkMalzemeTutar.Location = new System.Drawing.Point(319, 2);
            this.txtEkMalzemeTutar.Name = "txtEkMalzemeTutar";
            this.txtEkMalzemeTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkMalzemeTutar.Properties.Appearance.Options.UseFont = true;
            this.txtEkMalzemeTutar.Properties.DisplayFormat.FormatString = "C2";
            this.txtEkMalzemeTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtEkMalzemeTutar.Properties.ReadOnly = true;
            this.txtEkMalzemeTutar.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.txtEkMalzemeTutar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtEkMalzemeTutar.Size = new System.Drawing.Size(84, 30);
            this.txtEkMalzemeTutar.StyleController = this.layoutControl1;
            this.txtEkMalzemeTutar.TabIndex = 2;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtToplamTutar.Location = new System.Drawing.Point(117, 36);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Properties.Appearance.Options.UseFont = true;
            this.txtToplamTutar.Properties.DisplayFormat.FormatString = "C2";
            this.txtToplamTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtToplamTutar.Properties.ReadOnly = true;
            this.txtToplamTutar.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.txtToplamTutar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtToplamTutar.Size = new System.Drawing.Size(286, 30);
            this.txtToplamTutar.StyleController = this.layoutControl1;
            this.txtToplamTutar.TabIndex = 2;
            // 
            // txtPorsiyonTutar
            // 
            this.txtPorsiyonTutar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPorsiyonTutar.Location = new System.Drawing.Point(117, 2);
            this.txtPorsiyonTutar.Name = "txtPorsiyonTutar";
            this.txtPorsiyonTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPorsiyonTutar.Properties.Appearance.Options.UseFont = true;
            this.txtPorsiyonTutar.Properties.DisplayFormat.FormatString = "C2";
            this.txtPorsiyonTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorsiyonTutar.Properties.ReadOnly = true;
            this.txtPorsiyonTutar.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.txtPorsiyonTutar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtPorsiyonTutar.Size = new System.Drawing.Size(83, 30);
            this.txtPorsiyonTutar.StyleController = this.layoutControl1;
            this.txtPorsiyonTutar.TabIndex = 2;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(405, 68);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtPorsiyonTutar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(202, 34);
            this.layoutControlItem1.Text = "Porsiyon Tutar";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(103, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtToplamTutar;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(405, 34);
            this.layoutControlItem2.Text = "Toplam Tutar";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(103, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtEkMalzemeTutar;
            this.layoutControlItem3.Location = new System.Drawing.Point(202, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(203, 34);
            this.layoutControlItem3.Text = "Ek Malzeme Tutar";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(103, 16);
            // 
            // btnEkMalzemeOnay
            // 
            this.btnEkMalzemeOnay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEkMalzemeOnay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkMalzemeOnay.ImageOptions.Image")));
            this.btnEkMalzemeOnay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnEkMalzemeOnay.Location = new System.Drawing.Point(407, 2);
            this.btnEkMalzemeOnay.Name = "btnEkMalzemeOnay";
            this.btnEkMalzemeOnay.Size = new System.Drawing.Size(93, 65);
            this.btnEkMalzemeOnay.TabIndex = 0;
            this.btnEkMalzemeOnay.Text = "Onayla";
            this.btnEkMalzemeOnay.Click += new System.EventHandler(this.btnEkMalzemeOnay_Click);
            // 
            // pageGarson
            // 
            this.pageGarson.Caption = "pageGarson";
            this.pageGarson.Controls.Add(this.flowGarson);
            this.pageGarson.Name = "pageGarson";
            this.pageGarson.Size = new System.Drawing.Size(502, 719);
            // 
            // flowGarson
            // 
            this.flowGarson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowGarson.Location = new System.Drawing.Point(0, 0);
            this.flowGarson.Name = "flowGarson";
            this.flowGarson.Size = new System.Drawing.Size(502, 719);
            this.flowGarson.TabIndex = 0;
            // 
            // pageMusteri
            // 
            this.pageMusteri.Caption = "pageMusteri";
            this.pageMusteri.Controls.Add(this.flowMusteri);
            this.pageMusteri.Name = "pageMusteri";
            this.pageMusteri.Size = new System.Drawing.Size(502, 719);
            // 
            // flowMusteri
            // 
            this.flowMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMusteri.Location = new System.Drawing.Point(0, 0);
            this.flowMusteri.Name = "flowMusteri";
            this.flowMusteri.Size = new System.Drawing.Size(502, 719);
            this.flowMusteri.TabIndex = 0;
            // 
            // pageOdemeEkranı
            // 
            this.pageOdemeEkranı.Controls.Add(this.gridControlOdeme);
            this.pageOdemeEkranı.Controls.Add(this.layoutControl3);
            this.pageOdemeEkranı.Controls.Add(this.panelControl5);
            this.pageOdemeEkranı.Controls.Add(this.flowOdemeTurleri);
            this.pageOdemeEkranı.Name = "pageOdemeEkranı";
            this.pageOdemeEkranı.Size = new System.Drawing.Size(502, 719);
            // 
            // gridControlOdeme
            // 
            this.gridControlOdeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOdeme.Location = new System.Drawing.Point(0, 136);
            this.gridControlOdeme.MainView = this.gridOdeme;
            this.gridControlOdeme.Name = "gridControlOdeme";
            this.gridControlOdeme.Size = new System.Drawing.Size(502, 447);
            this.gridControlOdeme.TabIndex = 2;
            this.gridControlOdeme.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdeme});
            // 
            // gridOdeme
            // 
            this.gridOdeme.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOdemeTuruAdi,
            this.colTutar});
            this.gridOdeme.GridControl = this.gridControlOdeme;
            this.gridOdeme.Name = "gridOdeme";
            this.gridOdeme.OptionsView.ShowGroupPanel = false;
            this.gridOdeme.RowHeight = 40;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colOdemeTuruAdi.AppearanceCell.Options.UseFont = true;
            this.colOdemeTuruAdi.Caption = "Ödeme Türü";
            this.colOdemeTuruAdi.FieldName = "OdemeTuru.Adi";
            this.colOdemeTuruAdi.MinWidth = 25;
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 0;
            this.colOdemeTuruAdi.Width = 94;
            // 
            // colTutar
            // 
            this.colTutar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTutar.AppearanceCell.Options.UseFont = true;
            this.colTutar.Caption = "Tutar";
            this.colTutar.DisplayFormat.FormatString = "C2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.MinWidth = 25;
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 1;
            this.colTutar.Width = 94;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.layoutControl2);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl5.Location = new System.Drawing.Point(0, 583);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(502, 136);
            this.panelControl5.TabIndex = 1;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.txtKalanTutar);
            this.layoutControl2.Controls.Add(this.txtOdenenTutar);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl2.Location = new System.Drawing.Point(2, 92);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(498, 42);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // txtKalanTutar
            // 
            this.txtKalanTutar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtKalanTutar.Location = new System.Drawing.Point(351, 4);
            this.txtKalanTutar.Name = "txtKalanTutar";
            this.txtKalanTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalanTutar.Properties.Appearance.Options.UseFont = true;
            this.txtKalanTutar.Properties.AutoHeight = false;
            this.txtKalanTutar.Properties.DisplayFormat.FormatString = "C2";
            this.txtKalanTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKalanTutar.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.txtKalanTutar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtKalanTutar.Size = new System.Drawing.Size(143, 34);
            this.txtKalanTutar.StyleController = this.layoutControl2;
            this.txtKalanTutar.TabIndex = 2;
            // 
            // txtOdenenTutar
            // 
            this.txtOdenenTutar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtOdenenTutar.Location = new System.Drawing.Point(104, 4);
            this.txtOdenenTutar.Name = "txtOdenenTutar";
            this.txtOdenenTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdenenTutar.Properties.Appearance.Options.UseFont = true;
            this.txtOdenenTutar.Properties.AutoHeight = false;
            this.txtOdenenTutar.Properties.DisplayFormat.FormatString = "C2";
            this.txtOdenenTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOdenenTutar.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.txtOdenenTutar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtOdenenTutar.Size = new System.Drawing.Size(143, 34);
            this.txtOdenenTutar.StyleController = this.layoutControl2;
            this.txtOdenenTutar.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(498, 42);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.txtOdenenTutar;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(166, 34);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(247, 38);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Ödenen Tutar :";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(88, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.Control = this.txtKalanTutar;
            this.layoutControlItem5.Location = new System.Drawing.Point(247, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(166, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem5.Size = new System.Drawing.Size(247, 38);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "Kalan Tutar :";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(88, 16);
            // 
            // flowOdemeTurleri
            // 
            this.flowOdemeTurleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowOdemeTurleri.Location = new System.Drawing.Point(0, 0);
            this.flowOdemeTurleri.Name = "flowOdemeTurleri";
            this.flowOdemeTurleri.Size = new System.Drawing.Size(502, 81);
            this.flowOdemeTurleri.TabIndex = 0;
            // 
            // panelUrunGrupKeypad
            // 
            this.panelUrunGrupKeypad.Controls.Add(this.groupKategori);
            this.panelUrunGrupKeypad.Controls.Add(this.groupKeypad);
            this.panelUrunGrupKeypad.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUrunGrupKeypad.Location = new System.Drawing.Point(2, 2);
            this.panelUrunGrupKeypad.Name = "panelUrunGrupKeypad";
            this.panelUrunGrupKeypad.Size = new System.Drawing.Size(299, 719);
            this.panelUrunGrupKeypad.TabIndex = 0;
            // 
            // groupKategori
            // 
            this.groupKategori.Controls.Add(this.flowKategori);
            this.groupKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupKategori.Location = new System.Drawing.Point(2, 330);
            this.groupKategori.Name = "groupKategori";
            this.groupKategori.Size = new System.Drawing.Size(295, 387);
            this.groupKategori.TabIndex = 1;
            this.groupKategori.Text = "Ürün Grupları";
            // 
            // flowKategori
            // 
            this.flowKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowKategori.Location = new System.Drawing.Point(2, 28);
            this.flowKategori.Name = "flowKategori";
            this.flowKategori.Size = new System.Drawing.Size(291, 357);
            this.flowKategori.TabIndex = 0;
            // 
            // groupKeypad
            // 
            this.groupKeypad.Controls.Add(this.txtMiktar);
            this.groupKeypad.Controls.Add(this.btnKeypadOk);
            this.groupKeypad.Controls.Add(this.btnKeypadDel);
            this.groupKeypad.Controls.Add(this.btnKeypadBack);
            this.groupKeypad.Controls.Add(this.btnVirgul);
            this.groupKeypad.Controls.Add(this.btnBir);
            this.groupKeypad.Controls.Add(this.btnSekiz);
            this.groupKeypad.Controls.Add(this.btnDokuz);
            this.groupKeypad.Controls.Add(this.btnUc);
            this.groupKeypad.Controls.Add(this.btnSifir);
            this.groupKeypad.Controls.Add(this.btnIki);
            this.groupKeypad.Controls.Add(this.btnAlti);
            this.groupKeypad.Controls.Add(this.btnBes);
            this.groupKeypad.Controls.Add(this.btnDort);
            this.groupKeypad.Controls.Add(this.btnYedi);
            this.groupKeypad.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupKeypad.Location = new System.Drawing.Point(2, 2);
            this.groupKeypad.Name = "groupKeypad";
            this.groupKeypad.Size = new System.Drawing.Size(295, 328);
            this.groupKeypad.TabIndex = 0;
            this.groupKeypad.Text = "KeyPad";
            this.groupKeypad.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(8, 32);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Properties.Appearance.Options.UseFont = true;
            this.txtMiktar.Size = new System.Drawing.Size(281, 40);
            this.txtMiktar.TabIndex = 5;
            // 
            // btnKeypadOk
            // 
            this.btnKeypadOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKeypadOk.ImageOptions.Image")));
            this.btnKeypadOk.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKeypadOk.Location = new System.Drawing.Point(223, 205);
            this.btnKeypadOk.Name = "btnKeypadOk";
            this.btnKeypadOk.Size = new System.Drawing.Size(66, 117);
            this.btnKeypadOk.TabIndex = 4;
            this.btnKeypadOk.Click += new System.EventHandler(this.btnKeypadOk_Click);
            // 
            // btnKeypadDel
            // 
            this.btnKeypadDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKeypadDel.ImageOptions.Image")));
            this.btnKeypadDel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKeypadDel.Location = new System.Drawing.Point(223, 140);
            this.btnKeypadDel.Name = "btnKeypadDel";
            this.btnKeypadDel.Size = new System.Drawing.Size(66, 57);
            this.btnKeypadDel.TabIndex = 4;
            // 
            // btnKeypadBack
            // 
            this.btnKeypadBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKeypadBack.ImageOptions.Image")));
            this.btnKeypadBack.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKeypadBack.Location = new System.Drawing.Point(223, 77);
            this.btnKeypadBack.Name = "btnKeypadBack";
            this.btnKeypadBack.Size = new System.Drawing.Size(66, 57);
            this.btnKeypadBack.TabIndex = 4;
            // 
            // btnVirgul
            // 
            this.btnVirgul.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVirgul.Appearance.Options.UseFont = true;
            this.btnVirgul.Location = new System.Drawing.Point(8, 265);
            this.btnVirgul.Name = "btnVirgul";
            this.btnVirgul.Size = new System.Drawing.Size(66, 57);
            this.btnVirgul.TabIndex = 4;
            this.btnVirgul.Text = ",";
            this.btnVirgul.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // btnBir
            // 
            this.btnBir.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBir.Appearance.Options.UseFont = true;
            this.btnBir.Location = new System.Drawing.Point(7, 205);
            this.btnBir.Name = "btnBir";
            this.btnBir.Size = new System.Drawing.Size(66, 57);
            this.btnBir.TabIndex = 4;
            this.btnBir.Text = "1";
            this.btnBir.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // btnSekiz
            // 
            this.btnSekiz.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekiz.Appearance.Options.UseFont = true;
            this.btnSekiz.Location = new System.Drawing.Point(79, 76);
            this.btnSekiz.Name = "btnSekiz";
            this.btnSekiz.Size = new System.Drawing.Size(66, 57);
            this.btnSekiz.TabIndex = 4;
            this.btnSekiz.Text = "8";
            this.btnSekiz.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // btnDokuz
            // 
            this.btnDokuz.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDokuz.Appearance.Options.UseFont = true;
            this.btnDokuz.Location = new System.Drawing.Point(151, 77);
            this.btnDokuz.Name = "btnDokuz";
            this.btnDokuz.Size = new System.Drawing.Size(66, 57);
            this.btnDokuz.TabIndex = 4;
            this.btnDokuz.Text = "9";
            this.btnDokuz.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // btnUc
            // 
            this.btnUc.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUc.Appearance.Options.UseFont = true;
            this.btnUc.Location = new System.Drawing.Point(151, 205);
            this.btnUc.Name = "btnUc";
            this.btnUc.Size = new System.Drawing.Size(66, 57);
            this.btnUc.TabIndex = 4;
            this.btnUc.Text = "3";
            this.btnUc.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // btnSifir
            // 
            this.btnSifir.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifir.Appearance.Options.UseFont = true;
            this.btnSifir.Location = new System.Drawing.Point(80, 265);
            this.btnSifir.Name = "btnSifir";
            this.btnSifir.Size = new System.Drawing.Size(137, 57);
            this.btnSifir.TabIndex = 4;
            this.btnSifir.Text = "0";
            this.btnSifir.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // btnIki
            // 
            this.btnIki.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIki.Appearance.Options.UseFont = true;
            this.btnIki.Location = new System.Drawing.Point(79, 205);
            this.btnIki.Name = "btnIki";
            this.btnIki.Size = new System.Drawing.Size(66, 57);
            this.btnIki.TabIndex = 4;
            this.btnIki.Text = "2";
            this.btnIki.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // btnAlti
            // 
            this.btnAlti.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlti.Appearance.Options.UseFont = true;
            this.btnAlti.Location = new System.Drawing.Point(151, 142);
            this.btnAlti.Name = "btnAlti";
            this.btnAlti.Size = new System.Drawing.Size(66, 57);
            this.btnAlti.TabIndex = 4;
            this.btnAlti.Text = "6";
            this.btnAlti.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // btnBes
            // 
            this.btnBes.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBes.Appearance.Options.UseFont = true;
            this.btnBes.Location = new System.Drawing.Point(79, 142);
            this.btnBes.Name = "btnBes";
            this.btnBes.Size = new System.Drawing.Size(66, 57);
            this.btnBes.TabIndex = 4;
            this.btnBes.Text = "5";
            this.btnBes.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // btnDort
            // 
            this.btnDort.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDort.Appearance.Options.UseFont = true;
            this.btnDort.Location = new System.Drawing.Point(7, 140);
            this.btnDort.Name = "btnDort";
            this.btnDort.Size = new System.Drawing.Size(66, 57);
            this.btnDort.TabIndex = 4;
            this.btnDort.Text = "4";
            this.btnDort.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // btnYedi
            // 
            this.btnYedi.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedi.Appearance.Options.UseFont = true;
            this.btnYedi.Location = new System.Drawing.Point(7, 77);
            this.btnYedi.Name = "btnYedi";
            this.btnYedi.Size = new System.Drawing.Size(66, 57);
            this.btnYedi.TabIndex = 4;
            this.btnYedi.Text = "7";
            this.btnYedi.Click += new System.EventHandler(this.KeyPadSend);
            // 
            // panelUrunHareket
            // 
            this.panelUrunHareket.Controls.Add(this.gridControl1);
            this.panelUrunHareket.Controls.Add(this.panelControl4);
            this.panelUrunHareket.Controls.Add(this.panelControl2);
            this.panelUrunHareket.Controls.Add(this.panelUrunHareketMenu);
            this.panelUrunHareket.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUrunHareket.Location = new System.Drawing.Point(89, 0);
            this.panelUrunHareket.Name = "panelUrunHareket";
            this.panelUrunHareket.Size = new System.Drawing.Size(583, 723);
            this.panelUrunHareket.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 90);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(579, 551);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.CardCaption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.layoutView1.Appearance.CardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.SeparatorLine.BackColor = System.Drawing.Color.Red;
            this.layoutView1.Appearance.SeparatorLine.BackColor2 = System.Drawing.Color.GreenYellow;
            this.layoutView1.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.layoutView1.CardCaptionFormat = "{2}";
            this.layoutView1.CardMinSize = new System.Drawing.Size(533, 125);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colHareketTip,
            this.colUrunAdi,
            this.colMiktar,
            this.colBirimi,
            this.colBirimFiyat,
            this.colToplam,
            this.colAciklama});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1_6});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.AllowExpandCollapse = false;
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsItemText.TextToControlDistance = 7;
            this.layoutView1.OptionsMultiRecordMode.MaxCardColumns = 1;
            this.layoutView1.OptionsMultiRecordMode.StretchCardToViewWidth = true;
            this.layoutView1.OptionsView.CardArrangeRule = DevExpress.XtraGrid.Views.Layout.LayoutCardArrangeRule.AllowPartialCards;
            this.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column;
            this.layoutView1.PaintStyleName = "UltraFlat";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.CustomCardStyle += new DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventHandler(this.layoutView1_CustomCardStyle);
            // 
            // colHareketTip
            // 
            this.colHareketTip.Caption = "Hareket Tipi";
            this.colHareketTip.FieldName = "UrunHareketTip";
            this.colHareketTip.LayoutViewField = this.layoutViewField_layoutViewColumn1_6;
            this.colHareketTip.MinWidth = 25;
            this.colHareketTip.Name = "colHareketTip";
            this.colHareketTip.OptionsColumn.AllowFocus = false;
            this.colHareketTip.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colHareketTip.OptionsField.SortFilterButtonShowMode = DevExpress.XtraGrid.Views.Layout.SortFilterButtonShowMode.Nowhere;
            this.colHareketTip.OptionsFilter.AllowAutoFilter = false;
            this.colHareketTip.OptionsFilter.AllowFilter = false;
            this.colHareketTip.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1_6
            // 
            this.layoutViewField_layoutViewColumn1_6.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1_6.Location = new System.Drawing.Point(0, 122);
            this.layoutViewField_layoutViewColumn1_6.Name = "layoutViewField_layoutViewColumn1_6";
            this.layoutViewField_layoutViewColumn1_6.Size = new System.Drawing.Size(222, 20);
            this.layoutViewField_layoutViewColumn1_6.TextSize = new System.Drawing.Size(84, 16);
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.colUrunAdi.AppearanceCell.Options.UseFont = true;
            this.colUrunAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunAdi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "Urun.Adi";
            this.colUrunAdi.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.colUrunAdi.MinWidth = 25;
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowFocus = false;
            this.colUrunAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUrunAdi.OptionsField.SortFilterButtonShowMode = DevExpress.XtraGrid.Views.Layout.SortFilterButtonShowMode.Nowhere;
            this.colUrunAdi.OptionsFilter.AllowAutoFilter = false;
            this.colUrunAdi.OptionsFilter.AllowFilter = false;
            this.colUrunAdi.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 300;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(101, 0);
            this.layoutViewField_layoutViewColumn1.MaxSize = new System.Drawing.Size(0, 73);
            this.layoutViewField_layoutViewColumn1.MinSize = new System.Drawing.Size(22, 73);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(22, 73);
            this.layoutViewField_layoutViewColumn1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn1.TextVisible = false;
            // 
            // colMiktar
            // 
            this.colMiktar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold);
            this.colMiktar.AppearanceCell.Options.UseFont = true;
            this.colMiktar.AppearanceCell.Options.UseTextOptions = true;
            this.colMiktar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMiktar.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.DisplayFormat.FormatString = "N0";
            this.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.LayoutViewField = this.layoutViewField_layoutViewColumn1_1;
            this.colMiktar.MinWidth = 25;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowFocus = false;
            this.colMiktar.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMiktar.OptionsField.SortFilterButtonShowMode = DevExpress.XtraGrid.Views.Layout.SortFilterButtonShowMode.Nowhere;
            this.colMiktar.OptionsFilter.AllowAutoFilter = false;
            this.colMiktar.OptionsFilter.AllowFilter = false;
            this.colMiktar.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1_1
            // 
            this.layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 99;
            this.layoutViewField_layoutViewColumn1_1.Location = new System.Drawing.Point(0, 18);
            this.layoutViewField_layoutViewColumn1_1.MaxSize = new System.Drawing.Size(101, 69);
            this.layoutViewField_layoutViewColumn1_1.MinSize = new System.Drawing.Size(101, 69);
            this.layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            this.layoutViewField_layoutViewColumn1_1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_layoutViewColumn1_1.Size = new System.Drawing.Size(101, 69);
            this.layoutViewField_layoutViewColumn1_1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_layoutViewColumn1_1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn1_1.TextVisible = false;
            // 
            // colBirimi
            // 
            this.colBirimi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colBirimi.AppearanceCell.Options.UseFont = true;
            this.colBirimi.AppearanceCell.Options.UseTextOptions = true;
            this.colBirimi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirimi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Porsiyon.Birim.Adi";
            this.colBirimi.LayoutViewField = this.layoutViewField_layoutViewColumn1_2;
            this.colBirimi.MinWidth = 25;
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowFocus = false;
            this.colBirimi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBirimi.OptionsField.SortFilterButtonShowMode = DevExpress.XtraGrid.Views.Layout.SortFilterButtonShowMode.Nowhere;
            this.colBirimi.OptionsFilter.AllowAutoFilter = false;
            this.colBirimi.OptionsFilter.AllowFilter = false;
            this.colBirimi.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1_2
            // 
            this.layoutViewField_layoutViewColumn1_2.EditorPreferredWidth = 99;
            this.layoutViewField_layoutViewColumn1_2.Location = new System.Drawing.Point(0, 87);
            this.layoutViewField_layoutViewColumn1_2.MaxSize = new System.Drawing.Size(101, 35);
            this.layoutViewField_layoutViewColumn1_2.MinSize = new System.Drawing.Size(101, 35);
            this.layoutViewField_layoutViewColumn1_2.Name = "layoutViewField_layoutViewColumn1_2";
            this.layoutViewField_layoutViewColumn1_2.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_layoutViewColumn1_2.Size = new System.Drawing.Size(101, 35);
            this.layoutViewField_layoutViewColumn1_2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_layoutViewColumn1_2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn1_2.TextVisible = false;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colBirimFiyat.AppearanceCell.Options.UseFont = true;
            this.colBirimFiyat.AppearanceCell.Options.UseTextOptions = true;
            this.colBirimFiyat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirimFiyat.Caption = "Birim Fiyatı";
            this.colBirimFiyat.DisplayFormat.FormatString = "C2";
            this.colBirimFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyat.FieldName = "EkMalzemeliBirimFiyat";
            this.colBirimFiyat.LayoutViewField = this.layoutViewField_layoutViewColumn1_3;
            this.colBirimFiyat.MinWidth = 25;
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.OptionsColumn.AllowFocus = false;
            this.colBirimFiyat.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colBirimFiyat.OptionsField.SortFilterButtonShowMode = DevExpress.XtraGrid.Views.Layout.SortFilterButtonShowMode.Nowhere;
            this.colBirimFiyat.OptionsFilter.AllowAutoFilter = false;
            this.colBirimFiyat.OptionsFilter.AllowFilter = false;
            this.colBirimFiyat.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1_3
            // 
            this.layoutViewField_layoutViewColumn1_3.EditorPreferredWidth = 97;
            this.layoutViewField_layoutViewColumn1_3.Location = new System.Drawing.Point(123, 18);
            this.layoutViewField_layoutViewColumn1_3.MaxSize = new System.Drawing.Size(99, 28);
            this.layoutViewField_layoutViewColumn1_3.MinSize = new System.Drawing.Size(99, 28);
            this.layoutViewField_layoutViewColumn1_3.Name = "layoutViewField_layoutViewColumn1_3";
            this.layoutViewField_layoutViewColumn1_3.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_layoutViewColumn1_3.Size = new System.Drawing.Size(99, 28);
            this.layoutViewField_layoutViewColumn1_3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_layoutViewColumn1_3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn1_3.TextVisible = false;
            // 
            // colToplam
            // 
            this.colToplam.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.colToplam.AppearanceCell.Options.UseFont = true;
            this.colToplam.AppearanceCell.Options.UseTextOptions = true;
            this.colToplam.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colToplam.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colToplam.Caption = "Toplam";
            this.colToplam.FieldName = "ToplamTutar";
            this.colToplam.LayoutViewField = this.layoutViewField_layoutViewColumn1_4;
            this.colToplam.MinWidth = 25;
            this.colToplam.Name = "colToplam";
            this.colToplam.OptionsColumn.AllowFocus = false;
            this.colToplam.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colToplam.OptionsField.SortFilterButtonShowMode = DevExpress.XtraGrid.Views.Layout.SortFilterButtonShowMode.Nowhere;
            this.colToplam.OptionsFilter.AllowAutoFilter = false;
            this.colToplam.OptionsFilter.AllowFilter = false;
            this.colToplam.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1_4
            // 
            this.layoutViewField_layoutViewColumn1_4.EditorPreferredWidth = 97;
            this.layoutViewField_layoutViewColumn1_4.Location = new System.Drawing.Point(123, 73);
            this.layoutViewField_layoutViewColumn1_4.MaxSize = new System.Drawing.Size(99, 49);
            this.layoutViewField_layoutViewColumn1_4.MinSize = new System.Drawing.Size(99, 49);
            this.layoutViewField_layoutViewColumn1_4.Name = "layoutViewField_layoutViewColumn1_4";
            this.layoutViewField_layoutViewColumn1_4.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_layoutViewColumn1_4.Size = new System.Drawing.Size(99, 49);
            this.layoutViewField_layoutViewColumn1_4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_layoutViewColumn1_4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn1_4.TextVisible = false;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.LayoutViewField = this.layoutViewField_layoutViewColumn1_5;
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowFocus = false;
            this.colAciklama.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAciklama.OptionsField.SortFilterButtonShowMode = DevExpress.XtraGrid.Views.Layout.SortFilterButtonShowMode.Nowhere;
            this.colAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colAciklama.OptionsFilter.AllowFilter = false;
            this.colAciklama.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1_5
            // 
            this.layoutViewField_layoutViewColumn1_5.EditorPreferredWidth = 300;
            this.layoutViewField_layoutViewColumn1_5.Location = new System.Drawing.Point(101, 73);
            this.layoutViewField_layoutViewColumn1_5.MaxSize = new System.Drawing.Size(0, 49);
            this.layoutViewField_layoutViewColumn1_5.MinSize = new System.Drawing.Size(22, 49);
            this.layoutViewField_layoutViewColumn1_5.Name = "layoutViewField_layoutViewColumn1_5";
            this.layoutViewField_layoutViewColumn1_5.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_layoutViewColumn1_5.Size = new System.Drawing.Size(22, 49);
            this.layoutViewField_layoutViewColumn1_5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_layoutViewColumn1_5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn1_5.TextVisible = false;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.item2,
            this.layoutViewField_layoutViewColumn1_1,
            this.layoutViewField_layoutViewColumn1_2,
            this.layoutViewField_layoutViewColumn1_5,
            this.layoutViewField_layoutViewColumn1,
            this.item5,
            this.layoutViewField_layoutViewColumn1_3,
            this.item6,
            this.layoutViewField_layoutViewColumn1_4});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 7;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewCard1.Text = "TemplateCard";
            this.layoutViewCard1.TextLocation = DevExpress.Utils.Locations.Left;
            // 
            // item2
            // 
            this.item2.AllowHotTrack = false;
            this.item2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.item2.AppearanceItemCaption.Options.UseFont = true;
            this.item2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.item2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.item2.CustomizationFormText = "Miktar";
            this.item2.Location = new System.Drawing.Point(0, 0);
            this.item2.Name = "item2";
            this.item2.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.item2.Size = new System.Drawing.Size(101, 18);
            this.item2.Text = "Miktar";
            this.item2.TextSize = new System.Drawing.Size(84, 16);
            // 
            // item5
            // 
            this.item5.AllowHotTrack = false;
            this.item5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.item5.AppearanceItemCaption.Options.UseFont = true;
            this.item5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.item5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.item5.CustomizationFormText = "Biri Fiyat";
            this.item5.Location = new System.Drawing.Point(123, 0);
            this.item5.Name = "item5";
            this.item5.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.item5.Size = new System.Drawing.Size(99, 18);
            this.item5.Text = "Biri Fiyat";
            this.item5.TextSize = new System.Drawing.Size(84, 16);
            // 
            // item6
            // 
            this.item6.AllowHotTrack = false;
            this.item6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.item6.AppearanceItemCaption.Options.UseFont = true;
            this.item6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.item6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.item6.CustomizationFormText = "Toplam Tutar";
            this.item6.Location = new System.Drawing.Point(123, 46);
            this.item6.MaxSize = new System.Drawing.Size(99, 27);
            this.item6.MinSize = new System.Drawing.Size(99, 27);
            this.item6.Name = "item6";
            this.item6.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.item6.Size = new System.Drawing.Size(99, 27);
            this.item6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.item6.Text = "Toplam Tutar";
            this.item6.TextSize = new System.Drawing.Size(84, 16);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnIndirim);
            this.panelControl4.Controls.Add(this.btnBol);
            this.panelControl4.Controls.Add(this.btnIade);
            this.panelControl4.Controls.Add(this.btnMiktarAzalt);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 46);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(579, 44);
            this.panelControl4.TabIndex = 3;
            // 
            // btnIndirim
            // 
            this.btnIndirim.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndirim.Appearance.Options.UseFont = true;
            this.btnIndirim.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIndirim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIndirim.ImageOptions.Image")));
            this.btnIndirim.Location = new System.Drawing.Point(434, 2);
            this.btnIndirim.Name = "btnIndirim";
            this.btnIndirim.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnIndirim.Size = new System.Drawing.Size(144, 40);
            this.btnIndirim.TabIndex = 7;
            this.btnIndirim.Text = "İndirim";
            this.btnIndirim.Click += new System.EventHandler(this.btnIndirim_Click);
            // 
            // btnBol
            // 
            this.btnBol.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBol.Appearance.Options.UseFont = true;
            this.btnBol.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBol.ImageOptions.Image")));
            this.btnBol.Location = new System.Drawing.Point(290, 2);
            this.btnBol.Name = "btnBol";
            this.btnBol.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnBol.Size = new System.Drawing.Size(144, 40);
            this.btnBol.TabIndex = 6;
            this.btnBol.Text = "Böl";
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnIade
            // 
            this.btnIade.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIade.Appearance.Options.UseFont = true;
            this.btnIade.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIade.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIade.ImageOptions.Image")));
            this.btnIade.Location = new System.Drawing.Point(146, 2);
            this.btnIade.Name = "btnIade";
            this.btnIade.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnIade.Size = new System.Drawing.Size(144, 40);
            this.btnIade.TabIndex = 4;
            this.btnIade.Text = "İade";
            this.btnIade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // btnMiktarAzalt
            // 
            this.btnMiktarAzalt.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMiktarAzalt.Appearance.Options.UseFont = true;
            this.btnMiktarAzalt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMiktarAzalt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMiktarAzalt.ImageOptions.Image")));
            this.btnMiktarAzalt.Location = new System.Drawing.Point(2, 2);
            this.btnMiktarAzalt.Name = "btnMiktarAzalt";
            this.btnMiktarAzalt.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMiktarAzalt.Size = new System.Drawing.Size(144, 40);
            this.btnMiktarAzalt.TabIndex = 2;
            this.btnMiktarAzalt.Text = "Azalt";
            this.btnMiktarAzalt.Click += new System.EventHandler(this.btnMiktarAzalt_Click_1);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtUrunHareketIndirimTutar);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtUrunHareketOdenecekTutar);
            this.panelControl2.Controls.Add(this.txtToplamUrunHareketTutar);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 641);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(579, 80);
            this.panelControl2.TabIndex = 1;
            // 
            // txtUrunHareketIndirimTutar
            // 
            this.txtUrunHareketIndirimTutar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtUrunHareketIndirimTutar.Location = new System.Drawing.Point(416, 8);
            this.txtUrunHareketIndirimTutar.Name = "txtUrunHareketIndirimTutar";
            this.txtUrunHareketIndirimTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunHareketIndirimTutar.Properties.Appearance.Options.UseFont = true;
            this.txtUrunHareketIndirimTutar.Properties.DisplayFormat.FormatString = "C2";
            this.txtUrunHareketIndirimTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUrunHareketIndirimTutar.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.txtUrunHareketIndirimTutar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtUrunHareketIndirimTutar.Size = new System.Drawing.Size(158, 30);
            this.txtUrunHareketIndirimTutar.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(296, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 30);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "İndirim Tutar :";
            // 
            // txtUrunHareketOdenecekTutar
            // 
            this.txtUrunHareketOdenecekTutar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtUrunHareketOdenecekTutar.Location = new System.Drawing.Point(127, 44);
            this.txtUrunHareketOdenecekTutar.Name = "txtUrunHareketOdenecekTutar";
            this.txtUrunHareketOdenecekTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunHareketOdenecekTutar.Properties.Appearance.Options.UseFont = true;
            this.txtUrunHareketOdenecekTutar.Properties.DisplayFormat.FormatString = "C2";
            this.txtUrunHareketOdenecekTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUrunHareketOdenecekTutar.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.txtUrunHareketOdenecekTutar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtUrunHareketOdenecekTutar.Size = new System.Drawing.Size(447, 30);
            this.txtUrunHareketOdenecekTutar.TabIndex = 2;
            // 
            // txtToplamUrunHareketTutar
            // 
            this.txtToplamUrunHareketTutar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtToplamUrunHareketTutar.Location = new System.Drawing.Point(127, 8);
            this.txtToplamUrunHareketTutar.Name = "txtToplamUrunHareketTutar";
            this.txtToplamUrunHareketTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamUrunHareketTutar.Properties.Appearance.Options.UseFont = true;
            this.txtToplamUrunHareketTutar.Properties.DisplayFormat.FormatString = "C2";
            this.txtToplamUrunHareketTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtToplamUrunHareketTutar.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.txtToplamUrunHareketTutar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtToplamUrunHareketTutar.Size = new System.Drawing.Size(163, 30);
            this.txtToplamUrunHareketTutar.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(5, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(116, 30);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Ödenecek Tutar :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(5, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 30);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Toplam Tutar :";
            // 
            // panelUrunHareketMenu
            // 
            this.panelUrunHareketMenu.Controls.Add(this.btnEkMalzeme);
            this.panelUrunHareketMenu.Controls.Add(this.btnIkram);
            this.panelUrunHareketMenu.Controls.Add(this.btnFiyatDegistir);
            this.panelUrunHareketMenu.Controls.Add(this.btnMiktarArttir);
            this.panelUrunHareketMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUrunHareketMenu.Location = new System.Drawing.Point(2, 2);
            this.panelUrunHareketMenu.Name = "panelUrunHareketMenu";
            this.panelUrunHareketMenu.Size = new System.Drawing.Size(579, 44);
            this.panelUrunHareketMenu.TabIndex = 0;
            // 
            // btnEkMalzeme
            // 
            this.btnEkMalzeme.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkMalzeme.Appearance.Options.UseFont = true;
            this.btnEkMalzeme.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEkMalzeme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkMalzeme.ImageOptions.Image")));
            this.btnEkMalzeme.Location = new System.Drawing.Point(434, 2);
            this.btnEkMalzeme.Name = "btnEkMalzeme";
            this.btnEkMalzeme.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEkMalzeme.Size = new System.Drawing.Size(144, 40);
            this.btnEkMalzeme.TabIndex = 6;
            this.btnEkMalzeme.Text = "Ek\r\nMalzeme";
            this.btnEkMalzeme.Click += new System.EventHandler(this.btnEkMalzeme_Click);
            // 
            // btnIkram
            // 
            this.btnIkram.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIkram.Appearance.Options.UseFont = true;
            this.btnIkram.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIkram.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIkram.ImageOptions.Image")));
            this.btnIkram.Location = new System.Drawing.Point(290, 2);
            this.btnIkram.Name = "btnIkram";
            this.btnIkram.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnIkram.Size = new System.Drawing.Size(144, 40);
            this.btnIkram.TabIndex = 4;
            this.btnIkram.Text = "İkram";
            this.btnIkram.Click += new System.EventHandler(this.btnIkram_Click);
            // 
            // btnFiyatDegistir
            // 
            this.btnFiyatDegistir.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyatDegistir.Appearance.Options.UseFont = true;
            this.btnFiyatDegistir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFiyatDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiyatDegistir.ImageOptions.Image")));
            this.btnFiyatDegistir.Location = new System.Drawing.Point(146, 2);
            this.btnFiyatDegistir.Name = "btnFiyatDegistir";
            this.btnFiyatDegistir.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnFiyatDegistir.Size = new System.Drawing.Size(144, 40);
            this.btnFiyatDegistir.TabIndex = 2;
            this.btnFiyatDegistir.Text = "Fiyat\r\nDeğiştir";
            this.btnFiyatDegistir.Click += new System.EventHandler(this.btnFiyatDegistir_Click);
            // 
            // btnMiktarArttir
            // 
            this.btnMiktarArttir.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMiktarArttir.Appearance.Options.UseFont = true;
            this.btnMiktarArttir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMiktarArttir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMiktarArttir.ImageOptions.Image")));
            this.btnMiktarArttir.Location = new System.Drawing.Point(2, 2);
            this.btnMiktarArttir.Name = "btnMiktarArttir";
            this.btnMiktarArttir.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMiktarArttir.Size = new System.Drawing.Size(144, 40);
            this.btnMiktarArttir.TabIndex = 0;
            this.btnMiktarArttir.Text = "Arttır";
            this.btnMiktarArttir.Click += new System.EventHandler(this.btnMiktarArttir_Click);
            // 
            // panelHareketSolMenu
            // 
            this.panelHareketSolMenu.Controls.Add(this.btnSiparisKaydet);
            this.panelHareketSolMenu.Controls.Add(this.btnSiparisIptal);
            this.panelHareketSolMenu.Controls.Add(this.btnAdisyonDetay);
            this.panelHareketSolMenu.Controls.Add(this.btnYazdir);
            this.panelHareketSolMenu.Controls.Add(this.btnOdemeEkle);
            this.panelHareketSolMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHareketSolMenu.Location = new System.Drawing.Point(0, 0);
            this.panelHareketSolMenu.Name = "panelHareketSolMenu";
            this.panelHareketSolMenu.Size = new System.Drawing.Size(89, 723);
            this.panelHareketSolMenu.TabIndex = 0;
            // 
            // btnSiparisKaydet
            // 
            this.btnSiparisKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisKaydet.Appearance.Options.UseFont = true;
            this.btnSiparisKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSiparisKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSiparisKaydet.ImageOptions.Image")));
            this.btnSiparisKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSiparisKaydet.Location = new System.Drawing.Point(2, 641);
            this.btnSiparisKaydet.MaximumSize = new System.Drawing.Size(0, 80);
            this.btnSiparisKaydet.Name = "btnSiparisKaydet";
            this.btnSiparisKaydet.Size = new System.Drawing.Size(85, 80);
            this.btnSiparisKaydet.TabIndex = 4;
            this.btnSiparisKaydet.Text = "Değişiklikleri\r\n Kaydet";
            this.btnSiparisKaydet.Click += new System.EventHandler(this.btnSiparisKaydet_Click);
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisIptal.Appearance.Options.UseFont = true;
            this.btnSiparisIptal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSiparisIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSiparisIptal.ImageOptions.Image")));
            this.btnSiparisIptal.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSiparisIptal.Location = new System.Drawing.Point(2, 242);
            this.btnSiparisIptal.MaximumSize = new System.Drawing.Size(0, 80);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(85, 80);
            this.btnSiparisIptal.TabIndex = 3;
            this.btnSiparisIptal.Text = "Sipariş İptal";
            // 
            // btnAdisyonDetay
            // 
            this.btnAdisyonDetay.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdisyonDetay.Appearance.Options.UseFont = true;
            this.btnAdisyonDetay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdisyonDetay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdisyonDetay.ImageOptions.Image")));
            this.btnAdisyonDetay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAdisyonDetay.Location = new System.Drawing.Point(2, 162);
            this.btnAdisyonDetay.MaximumSize = new System.Drawing.Size(0, 80);
            this.btnAdisyonDetay.Name = "btnAdisyonDetay";
            this.btnAdisyonDetay.Size = new System.Drawing.Size(85, 80);
            this.btnAdisyonDetay.TabIndex = 2;
            this.btnAdisyonDetay.Text = "Adisyon\r\n Detay";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Appearance.Options.UseFont = true;
            this.btnYazdir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdir.ImageOptions.Image")));
            this.btnYazdir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnYazdir.Location = new System.Drawing.Point(2, 82);
            this.btnYazdir.MaximumSize = new System.Drawing.Size(0, 80);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(85, 80);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "Yazdır";
            // 
            // btnOdemeEkle
            // 
            this.btnOdemeEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeEkle.Appearance.Options.UseFont = true;
            this.btnOdemeEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOdemeEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeEkle.ImageOptions.Image")));
            this.btnOdemeEkle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnOdemeEkle.Location = new System.Drawing.Point(2, 2);
            this.btnOdemeEkle.MaximumSize = new System.Drawing.Size(0, 80);
            this.btnOdemeEkle.Name = "btnOdemeEkle";
            this.btnOdemeEkle.Size = new System.Drawing.Size(85, 80);
            this.btnOdemeEkle.TabIndex = 0;
            this.btnOdemeEkle.Text = "Ödeme Ekle";
            this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.txtOdemeTutari);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl3.Location = new System.Drawing.Point(0, 81);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup2;
            this.layoutControl3.Size = new System.Drawing.Size(502, 55);
            this.layoutControl3.TabIndex = 3;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup2.Size = new System.Drawing.Size(502, 55);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // txtOdemeTutari
            // 
            this.txtOdemeTutari.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtOdemeTutari.Location = new System.Drawing.Point(95, 4);
            this.txtOdemeTutari.Name = "txtOdemeTutari";
            this.txtOdemeTutari.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeTutari.Properties.Appearance.Options.UseFont = true;
            this.txtOdemeTutari.Properties.AutoHeight = false;
            this.txtOdemeTutari.Properties.DisplayFormat.FormatString = "C2";
            this.txtOdemeTutari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOdemeTutari.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.txtOdemeTutari.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtOdemeTutari.Size = new System.Drawing.Size(403, 47);
            this.txtOdemeTutari.StyleController = this.layoutControl3;
            this.txtOdemeTutari.TabIndex = 2;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtOdemeTutari;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(498, 51);
            this.layoutControlItem6.Text = "Ödeme Tutarı";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(79, 16);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 767);
            this.Controls.Add(this.navigationMain);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationMain)).EndInit();
            this.navigationMain.ResumeLayout(false);
            this.pageMasalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupMasalar)).EndInit();
            this.groupMasalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupKonumlar)).EndInit();
            this.groupKonumlar.ResumeLayout(false);
            this.pageAdisyonAyrinti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelUrunHareketHizliSatis)).EndInit();
            this.panelUrunHareketHizliSatis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationKategori)).EndInit();
            this.navigationKategori.ResumeLayout(false);
            this.pageKategoriUrunler.ResumeLayout(false);
            this.pageUrunPorsiyon.ResumeLayout(false);
            this.pageEkMalzeme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEkMalzemeTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorsiyonTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.pageGarson.ResumeLayout(false);
            this.pageMusteri.ResumeLayout(false);
            this.pageOdemeEkranı.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKalanTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdenenTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUrunGrupKeypad)).EndInit();
            this.panelUrunGrupKeypad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupKategori)).EndInit();
            this.groupKategori.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupKeypad)).EndInit();
            this.groupKeypad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUrunHareket)).EndInit();
            this.panelUrunHareket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunHareketIndirimTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunHareketOdenecekTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamUrunHareketTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUrunHareketMenu)).EndInit();
            this.panelUrunHareketMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelHareketSolMenu)).EndInit();
            this.panelHareketSolMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTutari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationMain;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMasalar;
        private DevExpress.XtraBars.Navigation.NavigationPage pageAdisyonAyrinti;
        private DevExpress.XtraEditors.PanelControl panelUrunHareket;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelUrunHareketMenu;
        private DevExpress.XtraEditors.PanelControl panelHareketSolMenu;
        private DevExpress.XtraEditors.SimpleButton btnSiparisKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSiparisIptal;
        private DevExpress.XtraEditors.SimpleButton btnAdisyonDetay;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
        private DevExpress.XtraEditors.SimpleButton btnOdemeEkle;
        private DevExpress.XtraEditors.PanelControl panelUrunHareketHizliSatis;
        private DevExpress.XtraEditors.PanelControl panelUrunGrupKeypad;
        private DevExpress.XtraEditors.GroupControl groupKeypad;
        private DevExpress.XtraEditors.SimpleButton btnKeypadOk;
        private DevExpress.XtraEditors.SimpleButton btnKeypadDel;
        private DevExpress.XtraEditors.SimpleButton btnKeypadBack;
        private DevExpress.XtraEditors.SimpleButton btnVirgul;
        private DevExpress.XtraEditors.SimpleButton btnBir;
        private DevExpress.XtraEditors.SimpleButton btnDokuz;
        private DevExpress.XtraEditors.SimpleButton btnUc;
        private DevExpress.XtraEditors.SimpleButton btnSifir;
        private DevExpress.XtraEditors.SimpleButton btnIki;
        private DevExpress.XtraEditors.SimpleButton btnAlti;
        private DevExpress.XtraEditors.SimpleButton btnBes;
        private DevExpress.XtraEditors.SimpleButton btnDort;
        private DevExpress.XtraEditors.SimpleButton btnYedi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraEditors.CalcEdit txtUrunHareketIndirimTutar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CalcEdit txtUrunHareketOdenecekTutar;
        private DevExpress.XtraEditors.CalcEdit txtToplamUrunHareketTutar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnEkMalzeme;
        private DevExpress.XtraEditors.SimpleButton btnIkram;
        private DevExpress.XtraEditors.SimpleButton btnFiyatDegistir;
        private DevExpress.XtraEditors.SimpleButton btnMiktarArttir;
        private DevExpress.XtraEditors.SimpleButton btnSekiz;
        private DevExpress.XtraEditors.GroupControl groupKategori;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colUrunAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMiktar;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBirimi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBirimFiyat;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colToplam;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAciklama;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.SimpleLabelItem item2;
        private DevExpress.XtraLayout.SimpleLabelItem item5;
        private DevExpress.XtraLayout.SimpleLabelItem item6;
        private System.Windows.Forms.FlowLayoutPanel flowKategori;
        private System.Windows.Forms.FlowLayoutPanel flowKategoriUrunleri;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationKategori;
        private DevExpress.XtraBars.Navigation.NavigationPage pageKategoriUrunler;
        private DevExpress.XtraBars.Navigation.NavigationPage pageUrunPorsiyon;
        private System.Windows.Forms.FlowLayoutPanel flowPoriyon;
        private DevExpress.XtraBars.Navigation.NavigationPage pageEkMalzeme;
        private System.Windows.Forms.FlowLayoutPanel flowEkMalzeme;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnEkMalzemeOnay;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colHareketTip;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_6;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CalcEdit txtEkMalzemeTutar;
        private DevExpress.XtraEditors.CalcEdit txtToplamTutar;
        private DevExpress.XtraEditors.CalcEdit txtPorsiyonTutar;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnKategoriyeDon;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnIndirim;
        private DevExpress.XtraEditors.SimpleButton btnBol;
        private DevExpress.XtraEditors.SimpleButton btnIade;
        private DevExpress.XtraEditors.SimpleButton btnMiktarAzalt;
        private DevExpress.XtraEditors.CalcEdit txtMiktar;
        private System.Windows.Forms.FlowLayoutPanel flowMasalar;
        private DevExpress.XtraEditors.GroupControl groupMasalar;
        private DevExpress.XtraEditors.GroupControl groupKonumlar;
        private System.Windows.Forms.FlowLayoutPanel flowKonum;
        private UserControls.ControlGarsonButton btnGarsonSecim;
        private DevExpress.XtraBars.Navigation.NavigationPage pageGarson;
        private System.Windows.Forms.FlowLayoutPanel flowGarson;
        private UserControls.ControlMusteriButton btnMusteri;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMusteri;
        private System.Windows.Forms.FlowLayoutPanel flowMusteri;
        private DevExpress.XtraBars.Navigation.NavigationPage pageOdemeEkranı;
        private DevExpress.XtraGrid.GridControl gridControlOdeme;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdeme;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.FlowLayoutPanel flowOdemeTurleri;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.CalcEdit txtKalanTutar;
        private DevExpress.XtraEditors.CalcEdit txtOdenenTutar;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.CalcEdit txtOdemeTutari;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}