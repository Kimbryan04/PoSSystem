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

namespace WindowsFormsApp2
{
    public partial class Reset_Password : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        UserAccount user;

        public Reset_Password(UserAccount use)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            user = use;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtRpnew.Text != txtRpCon.Text)
            {
                MessageBox.Show("The password you typed did not match. Type the password for this account in both text boxes.", "Add user Wizard", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(MessageBox.Show("Reset password?", "Connfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.ExecuteQuery("Update tbUser Set password = '" + txtRpnew.Text + "' Where username ='" + user.username + " '");
                    MessageBox.Show("Password has been successfully reset", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
