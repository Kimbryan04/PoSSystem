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
    public partial class Supplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Supplier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadSupplier();
        }

        public void LoadSupplier()
        {
            int i = 0;
            dvgSupplier.Rows.Clear();
            try
            {
                // Using parameterized query to avoid SQL injection
                cm = new SqlCommand("SELECT id, supplier, address, contact_person, phone, email, fax FROM tbSupplier WHERE CONCAT(supplier, address, email) LIKE @searchText", cn);
                cm.Parameters.AddWithValue("@searchText", "%" + txtsearch.Text + "%");
                cn.Open();
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    // Assuming the id is in the first column (index 0), and other columns follow
                    dvgSupplier.Rows.Add(i, dr["id"].ToString(), dr["supplier"].ToString(), dr["address"].ToString(), dr["contact_person"].ToString(), dr["phone"].ToString(), dr["email"].ToString(), dr["fax"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void dvgSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SupplierModule moduleform = new SupplierModule(this);
            moduleform.ShowDialog();
        }

        private void dvgSupplier_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgSupplier.Columns[e.ColumnIndex].Name;

            if (colname == "Edit")
            {
                SupplierModule supplierModule = new SupplierModule(this);
                supplierModule.lblsupplier.Text = dvgSupplier[1, e.RowIndex].Value.ToString();
                supplierModule.txtsupplier.Text = dvgSupplier[2, e.RowIndex].Value.ToString();
                supplierModule.txtaddress.Text = dvgSupplier[3, e.RowIndex].Value.ToString();
                supplierModule.txtcontact.Text = dvgSupplier[4, e.RowIndex].Value.ToString();
                supplierModule.txtphone.Text = dvgSupplier[5, e.RowIndex].Value.ToString();
                supplierModule.txtemail.Text = dvgSupplier[6, e.RowIndex].Value.ToString();
                supplierModule.txtfax.Text = dvgSupplier[7, e.RowIndex].Value.ToString();

                supplierModule.btnsave.Enabled = false;
                supplierModule.btnupdate.Enabled = true;
                supplierModule.ShowDialog();
            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Assuming the ID is in the second column (index 1), adjust the column index if needed
                        string supplierId = dvgSupplier[1, e.RowIndex].Value.ToString();

                        // Use parameterized query to avoid SQL injection
                        cm = new SqlCommand("DELETE FROM tbSupplier WHERE id = @id", cn);
                        cm.Parameters.AddWithValue("@id", supplierId);
                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Product has been successfully deleted.", "POINT OF SALES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }

                    // Reload the supplier list after deletion
                    LoadSupplier();
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
            SupplierModule moduleform = new SupplierModule(this);
            moduleform.btnsave.Enabled = true;
            moduleform.btnupdate.Enabled = false;
            moduleform.ShowDialog();
            LoadSupplier();
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            LoadSupplier();
        }
    }
}
