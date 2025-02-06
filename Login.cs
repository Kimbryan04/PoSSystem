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
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point of Sales";
        SqlDataReader dr;

        public string _pass = "";
        public bool _isactive;

        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Apllication?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string _username = "", _name = "", _role = "";
            try
            {
                bool found;
                cn.Open();
                cm = new SqlCommand("Select * from tbUser where username = @username And password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtusername.Text);
                cm.Parameters.AddWithValue("@password", txtpass.Text);
                dr = cm.ExecuteReader();
                dr.Read();

                if(dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _name = dr["name"].ToString();
                    _role = dr["role"].ToString() ;
                    _pass = dr["password"].ToString();
                    _isactive = bool.Parse(dr["isactivate"].ToString());

                }
                else
                {
                    found = false;
                }
                dr.Close(); 
                cn.Close();

                if(found)
                {
                    if (!_isactive)
                    {
                        MessageBox.Show("Account is deactivate, Unable to Login", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(_role == "Cashier")
                    {
                        MessageBox.Show("Welcome " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtusername.Clear();
                        txtpass.Clear();
                        this.Hide();
                        Cashier cashier = new Cashier();
                        cashier.lblusername.Text = _username;
                        cashier.lbltitle.Text = _name + "|" + _role;
                        cashier.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtusername.Clear();
                        txtpass.Clear();
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.lblusername.Text = _username;
                        mainForm._pass = _pass;
                        mainForm.lbltitle.Text = _name + "|" + _role;
                        mainForm.ShowDialog();


                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Errro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpass.Clear();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnlogin.PerformClick(); 
            }
        }
    }
}
