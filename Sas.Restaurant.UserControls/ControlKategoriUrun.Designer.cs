
namespace Sas.Restaurant.UserControls
{
    partial class ControlKategoriUrun
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
            this.groupBase = new DevExpress.XtraEditors.GroupControl();
            this.picfoto = new DevExpress.XtraEditors.PictureEdit();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupBase)).BeginInit();
            this.groupBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBase
            // 
            this.groupBase.Controls.Add(this.picfoto);
            this.groupBase.Controls.Add(this.lblAciklama);
            this.groupBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBase.Location = new System.Drawing.Point(0, 0);
            this.groupBase.Name = "groupBase";
            this.groupBase.Size = new System.Drawing.Size(309, 289);
            this.groupBase.TabIndex = 0;
            this.groupBase.Text = "groupControl1";
            this.groupBase.Click += new System.EventHandler(this.groupBase_Click);
            // 
            // picfoto
            // 
            this.picfoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picfoto.Location = new System.Drawing.Point(2, 28);
            this.picfoto.Name = "picfoto";
            this.picfoto.Properties.AllowFocused = false;
            this.picfoto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picfoto.Properties.Appearance.Options.UseBackColor = true;
            this.picfoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picfoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picfoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picfoto.Size = new System.Drawing.Size(305, 197);
            this.picfoto.TabIndex = 0;
            this.picfoto.Click += new System.EventHandler(this.picfoto_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Appearance.Options.UseTextOptions = true;
            this.lblAciklama.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblAciklama.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAciklama.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAciklama.Location = new System.Drawing.Point(2, 225);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(305, 62);
            this.lblAciklama.TabIndex = 1;
            this.lblAciklama.Click += new System.EventHandler(this.lblAciklama_Click);
            // 
            // ControlKategoriUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBase);
            this.Name = "ControlKategoriUrun";
            this.Size = new System.Drawing.Size(309, 289);
            ((System.ComponentModel.ISupportInitialize)(this.groupBase)).EndInit();
            this.groupBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picfoto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupBase;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private DevExpress.XtraEditors.PictureEdit picfoto;
    }
}
