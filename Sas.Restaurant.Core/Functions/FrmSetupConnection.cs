using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.Core.Functions
{
    public partial class FrmSetupConnection : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        public bool Kaydedildi=false;
        public FrmSetupConnection()
        {
            InitializeComponent();
        }
        private void BaglantiCumleOlustur()
        {
            connectionStringBuilder.InitialCatalog = "master";
            connectionStringBuilder.DataSource = txtServer.Text;

            if (chkWindows.Checked)
            {
                connectionStringBuilder.IntegratedSecurity = true;
            }
            else
            {
                connectionStringBuilder.UserID = txtUser.Text;
                connectionStringBuilder.Password = txtPassword.Text;
                connectionStringBuilder.IntegratedSecurity = false;
            }      
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            if (ConnectionStringInfo.Check(connectionStringBuilder.ConnectionString))
            {
                connectionStringBuilder.InitialCatalog = "Restaurant";
                ConnectionStringInfo.Set(connectionStringBuilder.ConnectionString);
                Kaydedildi = true;
                Close();
            }
            else
            {
                MessageBox.Show("Bağlantı başarısız");
            }
        }

        private void txtUser_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void chkSql_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSql.Checked)
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void btnBaglantiTest_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            if (ConnectionStringInfo.Check(connectionStringBuilder.ConnectionString))
            {
                MessageBox.Show("Bağlantı başarılı");
            }
            else
            {
                MessageBox.Show("Bağlantı başarısız");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}