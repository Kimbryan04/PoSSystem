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
    public partial class Brand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Brand()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadBrand();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadBrand()
        {
            int i = 0;
            dvgBrand.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbBrand ORDER BY brand", cn);
            dr = cm.ExecuteReader();

            while (dr.Read()) 
            { 
                dvgBrand.Rows.Add(i++, dr["id"].ToString(), dr["brand"].ToString());
            
            }
            dr.Close(); 
            cn.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BrandModuleForm moduleform = new BrandModuleForm(this);
            moduleform.ShowDialog();
        }

        private void dvgBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgBrand.Columns[e.ColumnIndex].Name;
            if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbBrand WHERE id LIKE '" + dvgBrand[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfully deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if( colname == "Edit")
            {
                BrandModuleForm brandModuleForm = new BrandModuleForm(this);
                brandModuleForm.lblbrand.Text = dvgBrand[1, e.RowIndex].Value.ToString();
                brandModuleForm.txtBrand.Text = dvgBrand[2, e.RowIndex].Value.ToString();
                brandModuleForm.btnsave.Enabled = false;
                brandModuleForm.btnupdate.Enabled = true;
                brandModuleForm.ShowDialog();
            }
            LoadBrand();
        }

        private void Brand_Load(object sender, EventArgs e)
        {

        }
    }
}
