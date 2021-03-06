
namespace Sas.Restaurant.UI.BackOffice.Tanim
{
    partial class FrmTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTanim));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupTanimBilgi = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTanim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new Sas.Restaurant.UserControls.ControlMenuKayit();
            this.gridControlTanim = new DevExpress.XtraGrid.GridControl();
            this.gridTanim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupTanimBilgi)).BeginInit();
            this.groupTanimBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(680, 72);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tanım İşlemleri";
            // 
            // groupTanimBilgi
            // 
            this.groupTanimBilgi.Controls.Add(this.txtAciklama);
            this.groupTanimBilgi.Controls.Add(this.labelControl2);
            this.groupTanimBilgi.Controls.Add(this.txtTanim);
            this.groupTanimBilgi.Controls.Add(this.labelControl6);
            this.groupTanimBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTanimBilgi.Location = new System.Drawing.Point(0, 72);
            this.groupTanimBilgi.Name = "groupTanimBilgi";
            this.groupTanimBilgi.Size = new System.Drawing.Size(680, 171);
            this.groupTanimBilgi.TabIndex = 2;
            this.groupTanimBilgi.Text = "Tanım İşlemleri";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(127, 65);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(541, 97);
            this.txtAciklama.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(5, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 96);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Açıklama :";
            // 
            // txtTanim
            // 
            this.txtTanim.Location = new System.Drawing.Point(127, 39);
            this.txtTanim.Name = "txtTanim";
            this.txtTanim.Size = new System.Drawing.Size(541, 22);
            this.txtTanim.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(5, 40);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(116, 20);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Tanım :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.controlMenu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 243);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(680, 82);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Menü";
            // 
            // controlMenu
            // 
            this.controlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMenu.KapatVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.controlMenu.KayitAc = false;
            this.controlMenu.Location = new System.Drawing.Point(2, 28);
            this.controlMenu.Name = "controlMenu";
            this.controlMenu.SecVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.controlMenu.Size = new System.Drawing.Size(676, 52);
            this.controlMenu.TabIndex = 0;
            this.controlMenu.SecClick += new System.EventHandler(this.controlMenu_SecClick);
            this.controlMenu.EkleClick += new System.EventHandler(this.controlMenu_EkleClick);
            this.controlMenu.DuzenleClick += new System.EventHandler(this.controlMenu_DuzenleClick);
            this.controlMenu.SilClick += new System.EventHandler(this.controlMenu_SilClick);
            this.controlMenu.KaydetClick += new System.EventHandler(this.controlMenu_KaydetClick);
            this.controlMenu.VazgecClick += new System.EventHandler(this.controlMenu_VazgecClick);
            this.controlMenu.KapatClick += new System.EventHandler(this.controlMenu_KapatClick);
            // 
            // gridControlTanim
            // 
            this.gridControlTanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTanim.Location = new System.Drawing.Point(0, 325);
            this.gridControlTanim.MainView = this.gridTanim;
            this.gridControlTanim.Name = "gridControlTanim";
            this.gridControlTanim.Size = new System.Drawing.Size(680, 307);
            this.gridControlTanim.TabIndex = 4;
            this.gridControlTanim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTanim});
            // 
            // gridTanim
            // 
            this.gridTanim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTanim,
            this.colAciklama});
            this.gridTanim.GridControl = this.gridControlTanim;
            this.gridTanim.Name = "gridTanim";
            this.gridTanim.OptionsView.ShowAutoFilterRow = true;
            this.gridTanim.OptionsView.ShowGroupPanel = false;
            // 
            // colTanim
            // 
            this.colTanim.Caption = "Tanım";
            this.colTanim.FieldName = "Adi";
            this.colTanim.MinWidth = 25;
            this.colTanim.Name = "colTanim";
            this.colTanim.OptionsColumn.AllowEdit = false;
            this.colTanim.Visible = true;
            this.colTanim.VisibleIndex = 0;
            this.colTanim.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            this.colAciklama.Width = 94;
            // 
            // FrmTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 632);
            this.Controls.Add(this.gridControlTanim);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupTanimBilgi);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanımlar";
            ((System.ComponentModel.ISupportInitialize)(this.groupTanimBilgi)).EndInit();
            this.groupTanimBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupTanimBilgi;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTanim;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControls.ControlMenuKayit controlMenu;
        private DevExpress.XtraGrid.GridControl gridControlTanim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}