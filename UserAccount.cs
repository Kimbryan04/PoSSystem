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

    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public UserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

        }
        public void Clear()
        {
            txtusername.Clear();
            txtpass.Clear();
            txtrepass.Clear();
            cbrole.Text = "";
            txtfullname.Clear();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtpass.Text != txtrepass.Text)
                {
                    MessageBox.Show("Password did not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this User?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbUser(username, password, role, name) VALUES(@username, @password, @role, @name)", cn);
                    cm.Parameters.AddWithValue("@username", txtusername.Text);
                    cm.Parameters.AddWithValue("@password", txtpass.Text);
                    cm.Parameters.AddWithValue("@role", cbrole.Text);
                    cm.Parameters.AddWithValue("@name", txtfullname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Record has been successfully saved.", "POINT OF SALES");
                    Clear();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
