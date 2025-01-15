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
    public partial class SupplierModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Supplier sup;

        public SupplierModule(Supplier supplier)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            sup = supplier;

        }

        private void SupplierModule_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtsupplier.Clear();
            txtaddress.Clear();
            txtcontact.Clear();
            txtphone.Clear();
            txtemail.Clear();
            txtfax.Clear();
            

          
            txtsupplier.Focus();
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Supplier?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbSupplier(supplier, address, contact_person, phone, email, fax)VALUES(@supplier, @address, @contact_person, @phone, @email, @fax)", cn);
                    cm.Parameters.AddWithValue("@supplier", txtsupplier.Text);
                    cm.Parameters.AddWithValue("@address", txtaddress.Text);
                    cm.Parameters.AddWithValue("@contact_person", txtcontact.Text);
                    cm.Parameters.AddWithValue("@phone", txtphone.Text);
                    cm.Parameters.AddWithValue("@email", txtemail.Text);
                    cm.Parameters.AddWithValue("@fax", txtfax.Text);
                    
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.", "POINT OF SALES");
                    Clear();

                }
                sup.LoadSupplier();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Supplier?", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbSupplier SET supplier=@supplier, address=@address, contact_person=@contact_person, phone=@phone, email=@email, fax=@fax WHERE id=@id", cn);
                    cm.Parameters.AddWithValue("@id", lblsupplier.Text);
                    cm.Parameters.AddWithValue("@supplier", txtsupplier.Text);
                    cm.Parameters.AddWithValue("@address", txtaddress.Text);
                    cm.Parameters.AddWithValue("@contact_person", txtcontact.Text);

                    // Use Convert.ToInt32 to safely convert the selected values to integers
                    cm.Parameters.AddWithValue("@phone",txtphone.Text); // brand id
                    cm.Parameters.AddWithValue("@email",txtemail.Text );   // category id

                    cm.Parameters.AddWithValue("@fax", txtfax.Text);
                   
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully updated.", "POINT OF SALES");
                    Clear();
                    this.Dispose();

                }
                sup.LoadSupplier();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
