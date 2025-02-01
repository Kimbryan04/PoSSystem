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
    public partial class ChangePassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        Cashier cashier;
        public ChangePassword(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cashier = cash;
            lblusername.Text = cashier.lblusername.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string oldpass = dbcon.getPassword(lblusername.Text);
                if (oldpass != txtcurpass.Text)
                {
                   MessageBox.Show("Wrong Password, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtcurpass.Visible = false;
                    btnNext.Visible = false;

                    txtnewpass.Visible = true;
                    txtConpass.Visible = true;
                    btnSave.Visible = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtnewpass.Text != txtConpass.Text)
                {
                    MessageBox.Show("New Password and Confirm password did not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if(MessageBox.Show("Change password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbcon.ExecuteQuery("Update tbUser set password = '"+ txtnewpass.Text + "' Where username = '" + lblusername.Text + "'");
                        MessageBox.Show("Password has successfully updated", "Save Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
