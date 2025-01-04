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
    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Category()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadCategory();
        }

        public void LoadCategory()
        {
            int i = 0;
            dvgCategory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbCategory ORDER BY category", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                dvgCategory.Rows.Add(i++, dr["id"].ToString(), dr["category"].ToString());

            }
            dr.Close();
            cn.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CategoryModuleForm moduleform = new CategoryModuleForm(this);
            moduleform.ShowDialog();
        }

        private void dvgCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgCategory.Columns[e.ColumnIndex].Name;
            if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory WHERE id LIKE '" + dvgCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfully deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colname == "Edit")
            {
                CategoryModuleForm categoryModuleForm = new CategoryModuleForm(this);
                categoryModuleForm.lblCategory.Text = dvgCategory[1, e.RowIndex].Value.ToString();
                categoryModuleForm.txtCategory.Text = dvgCategory[2, e.RowIndex].Value.ToString();
                categoryModuleForm.btnsave.Enabled = false;
                categoryModuleForm.btnupdate.Enabled = true;
                categoryModuleForm.ShowDialog();
            }
            LoadCategory();
        }
    }
}
