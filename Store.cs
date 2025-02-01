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
    public partial class Store : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        bool storeinfohave = false;
        public Store()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadStore();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadStore()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Select * From tbStore", cn);
                dr=cm.ExecuteReader();
                dr.Read();

                if(dr.HasRows)
                {
                    txtSname.Text = dr["store"].ToString();
                    txtAddress.Text = dr["address"].ToString();
                }
                else
                {
                    txtSname.Clear();
                    txtAddress.Clear();
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Save store details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (storeinfohave)
                    {
                        dbcon.ExecuteQuery("Update tbStore Set store = '" + txtSname.Text + "', address = '" + txtAddress.Text + "'");

                    }
                    else
                    {
                        dbcon.ExecuteQuery("Insert Into tbStore(store, address) Values('"+ txtSname.Text+ "','"+ txtAddress.Text+ "')");

                    }

                    this.Dispose();
                    MessageBox.Show("Store detail has been successfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Store_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
