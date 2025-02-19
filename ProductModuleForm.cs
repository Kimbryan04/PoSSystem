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
    public partial class ProductModuleForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Product product;
        string pos = "POINT OF SALES";
        public ProductModuleForm(Product pro)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadBrand();
            LoadCategory();
            product = pro;
        }

        private void ProductModuleForm_Load(object sender, EventArgs e)
        {

        }

        public void LoadCategory()
        {
            cbcat.Items.Clear();
            cbcat.DataSource = dbcon.getTable("SELECT * FROM tbCategory ");
            cbcat.DisplayMember = "category";
            cbcat.ValueMember = "id";
        }

        public void LoadBrand()
        {
            cbbrand.Items.Clear();
            cbbrand.DataSource = dbcon.getTable("SELECT * FROM tbBrand ");
            cbbrand.DisplayMember = "brand";
            cbbrand.ValueMember = "id";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtPcode.Clear();
            txtbarcode.Clear();
            txtdesc.Clear();
            txtprice.Clear();
            cbcat.SelectedValue = 0;
            cbbrand.SelectedValue = 0;
            udre.Value = 1;

            txtPcode.Enabled = true;
            txtPcode.Focus();
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pcode, barcode, pdesc, bid, cid, price, reorder) VALUES(@pcode, @barcode, @pdesc, @bid, @cid, @price, @reorder)", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtbarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtdesc.Text);

                    // Use Convert.ToInt32 to safely convert the selected values to integers
                    cm.Parameters.AddWithValue("@bid", Convert.ToInt32(cbbrand.SelectedValue)); // brand id
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt32(cbcat.SelectedValue));   // category id

                    cm.Parameters.AddWithValue("@price", double.Parse(txtprice.Text));
                    cm.Parameters.AddWithValue("@reorder", udre.Value);

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Record has been successfully saved.", pos);
                    Clear();

                    product.LoadProduct();
                }
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
                if (MessageBox.Show("Are you sure you want to update this Product?", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET barcode=@barcode, pdesc=@pdesc, bid=@bid, cid=@cid, price=@price, reorder=@reorder WHERE pcode LIKE @pcode", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtbarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtdesc.Text);

                    // Use Convert.ToInt32 to safely convert the selected values to integers
                    cm.Parameters.AddWithValue("@bid", Convert.ToInt32(cbbrand.SelectedValue)); // brand id
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt32(cbcat.SelectedValue));   // category id

                    cm.Parameters.AddWithValue("@price", double.Parse(txtprice.Text));
                    cm.Parameters.AddWithValue("@reorder", udre.Value);

                    cn.Open();
                    cm.ExecuteNonQuery(); 
                    cn.Close();
                    MessageBox.Show("Product has been successfully updated.", pos);
                    Clear();
                    this.Dispose();

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

        private void ProductModuleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
