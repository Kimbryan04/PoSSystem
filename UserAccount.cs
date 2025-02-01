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
        SqlDataReader dr;
        MainForm mainForm;
        string username;
        string name;
        string role;
        string account;
        public UserAccount(MainForm main)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            mainForm = main;
            LoadUser();

        }

        public void LoadUser()
        {
            int i = 0;
            dvgUser.Rows.Clear();
            cm = new SqlCommand("SELECT * From tbUser",cn);
            cn.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dvgUser.Rows.Add(i, dr[0].ToString(), dr[3].ToString(), dr[4].ToString(), dr[2].ToString());

            }

            dr.Close();
            cn.Close();

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
            CPClear();
        }

        public void CPClear()
        {
            txtchcurpass.Clear();
            txtchnewpass.Clear();
            txtchrepass.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtchcurpass.Text != mainForm._pass)
                {
                    MessageBox.Show("Current Passowrd did not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(txtchnewpass.Text != txtchrepass.Text)
                {
                    MessageBox.Show("Confirm Passowrd did not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                dbcon.ExecuteQuery("Update tbUser Set password = '" + txtchnewpass + "' Where username ='" + lblusername.Text + " '");
                MessageBox.Show("Password has been sucessfully updated", "Change Passwod", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            lblusername.Text = mainForm.lblusername.Text;
        }

        private void dvgUser_SelectionChanged(object sender, EventArgs e)
        {
            int i = dvgUser.CurrentRow.Index;
            username = dvgUser[1, i].Value.ToString();
            name = dvgUser[2,i].Value.ToString();
            role = dvgUser[4,i].Value.ToString();
            account = dvgUser[3,i].Value.ToString();

            if(lblusername.Text == username)
            {
                btnRemove.Enabled = false;
                btnReset.Enabled = false;
                lblaccnote.Text = "To change your password, go to change password tag.";
            }
            else
            {
                btnRemove.Enabled = true;
                btnReset.Enabled = true;
                lblaccnote.Text = "To change the password for " + username + ", click reset Password.";
            }

            gBUser.Text = "Password For " + username;
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You chose to remove this account from this Point of Sales System's Users list. \n\n Are you sure you want to remove it? '"+username+" \\'"+role+"'", "User Account Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dbcon.ExecuteQuery("Delete From tbuser where username = '" + username + "'");
                MessageBox.Show("Account has been successfully deleted");
                LoadUser();
            }
        }
    }
}
