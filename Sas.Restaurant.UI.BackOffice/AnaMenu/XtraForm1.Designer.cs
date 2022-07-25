
namespace Sas.Restaurant.UI.BackOffice.AnaMenu
{
    partial class XtraForm1
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
            this.components = new System.ComponentModel.Container();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.adornerUIManager1 = new DevExpress.Utils.VisualEffects.AdornerUIManager(this.components);
            this.badge1 = new DevExpress.Utils.VisualEffects.Badge();
            this.controlBadgeButton1 = new Sas.Restaurant.UserControls.ControlBadgeButton();
            this.controlKeyboard1 = new Sas.Restaurant.UserControls.ControlKeyboard();
            this.controlKullaniciGiris1 = new Sas.Restaurant.UserControls.ControlKullaniciGiris();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(297, 58);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(481, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1115, 75);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(132, 118);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // adornerUIManager1
            // 
            this.adornerUIManager1.Elements.Add(this.badge1);
            this.adornerUIManager1.Owner = this;
            // 
            // badge1
            // 
            this.badge1.Properties.Text = "Ayşenur";
            this.badge1.TargetElement = this.simpleButton1;
            // 
            // controlBadgeButton1
            // 
            this.controlBadgeButton1.BadgeBackColor = System.Drawing.Color.Red;
            this.controlBadgeButton1.BadgeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.controlBadgeButton1.BadgeForeColor = System.Drawing.Color.White;
            this.controlBadgeButton1.Count = 0;
            this.controlBadgeButton1.Location = new System.Drawing.Point(875, 89);
            this.controlBadgeButton1.Name = "controlBadgeButton1";
            this.controlBadgeButton1.Size = new System.Drawing.Size(193, 104);
            this.controlBadgeButton1.TabIndex = 3;
            this.controlBadgeButton1.Text = "controlBadgeButton1";
            // 
            // controlKeyboard1
            // 
            this.controlKeyboard1.CapsLock = true;
            this.controlKeyboard1.FocusTextBox = null;
            this.controlKeyboard1.KeyboardButtonType = Sas.Restaurant.UserControls.KeyboardButtonType.Standart;
            this.controlKeyboard1.Location = new System.Drawing.Point(130, 232);
            this.controlKeyboard1.Name = "controlKeyboard1";
            this.controlKeyboard1.Size = new System.Drawing.Size(1132, 450);
            this.controlKeyboard1.TabIndex = 1;
            // 
            // controlKullaniciGiris1
            // 
            this.controlKullaniciGiris1.Location = new System.Drawing.Point(327, 61);
            this.controlKullaniciGiris1.Name = "controlKullaniciGiris1";
            this.controlKullaniciGiris1.Size = new System.Drawing.Size(429, 469);
            this.controlKullaniciGiris1.TabIndex = 4;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 703);
            this.Controls.Add(this.controlKullaniciGiris1);
            this.Controls.Add(this.controlBadgeButton1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.controlKeyboard1);
            this.Controls.Add(this.textEdit1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private UserControls.ControlKeyboard controlKeyboard1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Utils.VisualEffects.AdornerUIManager adornerUIManager1;
        private DevExpress.Utils.VisualEffects.Badge badge1;
        private UserControls.ControlBadgeButton controlBadgeButton1;
        private UserControls.ControlKullaniciGiris controlKullaniciGiris1;
    }
}