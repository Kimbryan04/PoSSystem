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
    public partial class Product : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Product()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadProduct();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductModuleForm moduleform = new ProductModuleForm(this);
            
            moduleform.btnsave.Enabled = true;
            moduleform.btnupdate.Enabled = false;
            
            LoadProduct();
           
            moduleform.ShowDialog();
        }
        
        public void LoadProduct()
        {
            int i = 0;
            dvgProduct.Rows.Clear();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder FROM tbProduct as p INNER JOIN tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory AS c ON c.id = p.cid WHERE CONCAT(p.pdesc, b.brand, c.category) LIKE '%" + txtsearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dvgProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

            }

            dr.Close();
            cn.Close();

        }
        private void dvgBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgProduct.Columns[e.ColumnIndex].Name;
            
              if (colname == "Edit")
            {
                ProductModuleForm productmoduleform = new ProductModuleForm(this);
                productmoduleform.txtPcode.Text = dvgProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                productmoduleform.txtbarcode.Text = dvgProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                productmoduleform.txtdesc.Text = dvgProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                productmoduleform.cbcat.Text = dvgProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                productmoduleform.cbbrand.Text = dvgProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                productmoduleform.txtprice.Text = dvgProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                productmoduleform.udre.Value = int.Parse(dvgProduct.Rows[e.RowIndex].Cells[7].Value.ToString());

                productmoduleform.btnsave.Enabled = false;
                productmoduleform.btnupdate.Enabled = true;
                productmoduleform.txtPcode.Enabled = false;
                productmoduleform.ShowDialog();
            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbProduct WHERE pcode LIKE '" + dvgProduct[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully deleted.", "POINT OF SALES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LoadProduct();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
