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
    public partial class BrandModuleForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public BrandModuleForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that the text box is not empty
                if (string.IsNullOrEmpty(txtBrand.Text))
                {
                    MessageBox.Show("Brand name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if validation fails
                }

                if (MessageBox.Show("Are you sure you want to save this Brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();

                    // Insert only into 'brand' column (assuming 'id' is an identity column)
                    cm = new SqlCommand("INSERT INTO tbBrand(brand) VALUES(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);

                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Record has been successfully saved.", "POS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtBrand.Clear();
        }
    }
}
