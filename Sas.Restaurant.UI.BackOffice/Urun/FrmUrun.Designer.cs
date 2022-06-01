
namespace Sas.Restaurant.UI.BackOffice.Urun
{
    partial class FrmUrun
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrun));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new Sas.Restaurant.UserControls.ControlAnMenuAlt();
            this.gridControlUrunler = new DevExpress.XtraGrid.GridControl();
            this.gridUrunler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFotograf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.picFotograf = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFotografEkle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFotografEkle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFotografEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1119, 72);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürünler";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.controlMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 588);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1119, 96);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // controlMenu
            // 
            this.controlMenu.ButtonFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.controlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMenu.Location = new System.Drawing.Point(2, 28);
            this.controlMenu.Name = "controlMenu";
            this.controlMenu.Size = new System.Drawing.Size(1115, 66);
            this.controlMenu.TabIndex = 0;
            this.controlMenu.ButtonEkle += new System.EventHandler(this.controlMenu_ButtonEkle);
            this.controlMenu.ButtonDuzenle += new System.EventHandler(this.controlMenu_ButtonDuzenle);
            this.controlMenu.ButtonSil += new System.EventHandler(this.controlMenu_ButtonSil);
            this.controlMenu.ButtonGuncelle += new System.EventHandler(this.controlMenu_ButtonGuncelle);
            this.controlMenu.ButtonKapat += new System.EventHandler(this.controlMenu_ButtonKapat);
            // 
            // gridControlUrunler
            // 
            this.gridControlUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrunler.Location = new System.Drawing.Point(0, 72);
            this.gridControlUrunler.MainView = this.gridUrunler;
            this.gridControlUrunler.Name = "gridControlUrunler";
            this.gridControlUrunler.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnFotografEkle,
            this.picFotograf});
            this.gridControlUrunler.Size = new System.Drawing.Size(1119, 516);
            this.gridControlUrunler.TabIndex = 2;
            this.gridControlUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUrunler});
            // 
            // gridUrunler
            // 
            this.gridUrunler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFotograf,
            this.colBarkod,
            this.colAdi,
            this.colUrunGrup,
            this.colFotografEkle});
            this.gridUrunler.GridControl = this.gridControlUrunler;
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.RowHeight = 100;
            // 
            // colFotograf
            // 
            this.colFotograf.Caption = "Fotograf";
            this.colFotograf.ColumnEdit = this.picFotograf;
            this.colFotograf.FieldName = "Fotograf";
            this.colFotograf.MaxWidth = 150;
            this.colFotograf.MinWidth = 150;
            this.colFotograf.Name = "colFotograf";
            this.colFotograf.OptionsColumn.AllowEdit = false;
            this.colFotograf.Visible = true;
            this.colFotograf.VisibleIndex = 0;
            this.colFotograf.Width = 150;
            // 
            // picFotograf
            // 
            this.picFotograf.Name = "picFotograf";
            this.picFotograf.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkodu";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 1;
            this.colBarkod.Width = 94;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Ürün Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.MinWidth = 25;
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 2;
            this.colAdi.Width = 94;
            // 
            // colUrunGrup
            // 
            this.colUrunGrup.Caption = "Kategori";
            this.colUrunGrup.FieldName = "UrunGrup.Adi";
            this.colUrunGrup.MinWidth = 25;
            this.colUrunGrup.Name = "colUrunGrup";
            this.colUrunGrup.OptionsColumn.AllowEdit = false;
            this.colUrunGrup.Visible = true;
            this.colUrunGrup.VisibleIndex = 3;
            this.colUrunGrup.Width = 94;
            // 
            // colFotografEkle
            // 
            this.colFotografEkle.Caption = "Fotograf Ekle";
            this.colFotografEkle.ColumnEdit = this.btnFotografEkle;
            this.colFotografEkle.MaxWidth = 80;
            this.colFotografEkle.MinWidth = 80;
            this.colFotografEkle.Name = "colFotografEkle";
            this.colFotografEkle.Visible = true;
            this.colFotografEkle.VisibleIndex = 4;
            this.colFotografEkle.Width = 80;
            // 
            // btnFotografEkle
            // 
            this.btnFotografEkle.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnFotografEkle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnFotografEkle.Name = "btnFotografEkle";
            this.btnFotografEkle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnFotografEkle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnFotografEkle_ButtonClick);
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 684);
            this.Controls.Add(this.gridControlUrunler);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUrun";
            this.Text = "FrmUrun";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFotografEkle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunler;
        private DevExpress.XtraGrid.Columns.GridColumn colFotograf;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit picFotograf;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colFotografEkle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnFotografEkle;
        private UserControls.ControlAnMenuAlt controlMenu;
    }
}