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
    }
}
