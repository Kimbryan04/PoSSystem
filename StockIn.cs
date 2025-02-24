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
    public partial class StockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public StockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadSupplier();
            GetRefNo();
            

        }

        public void GetRefNo()
        {
            Random rnd = new Random();
            txtrefno.Clear();
            txtrefno.Text += rnd.Next();
        }

        public void LoadSupplier()
        {
            cbsupplier.Items.Clear();
            cbsupplier.DataSource = dbcon.getTable("SELECT * FROM tbSupplier");
            cbsupplier.DisplayMember = "Supplier";
            cbsupplier.Text = "";
        }

        private void cbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        public void ProductForSupplier(string pcode)
        {
            string supplier = "";
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vw_StockIn WHERE pcode like '"+ pcode + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                supplier = dr["supplier"].ToString();
            }

            dr.Close();
            cn.Close();

            cbsupplier.Text = supplier;
;        }

        private void cbsupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void linkgenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefNo();
        }

        public void Loadstockin()
        {
            int i = 0;
            dvgStockIn.Rows.Clear();
            cn.Open();

            cm = new SqlCommand("SELECT * FROM vw_StockIn WHERE refno LIKE '"+ txtrefno.Text+ "' AND status LIKE 'Pending'", cn);

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                
                i++;
                dvgStockIn.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[0].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr["supplier"].ToString());

            }

            dr.Close();
            cn.Close();

        }

        private void linkclick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn productstock = new ProductStockIn(this);
            productstock.ShowDialog();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgStockIn.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to save this record?", "POINT OF SALES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dvgStockIn.Rows.Count; i++) 
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbProduct SET qty = qty + " + int.Parse(dvgStockIn.Rows[i].Cells[5].Value.ToString()) + "WHERE pcode LIKE '" + dvgStockIn.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();


                            cn.Open();
                            cm = new SqlCommand("UPDATE tbStock SET qty = qty + " + int.Parse(dvgStockIn.Rows[i].Cells[5].Value.ToString()) + ", status = 'Done' WHERE id LIKE '" + dvgStockIn.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();


                        }
                        Clear();
                        Loadstockin();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "POINT OF SALES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void Clear()
        {
            txtrefno.Clear();
            txtstockin.Clear();
            dtpsdate.Value = DateTime.Now;

        }

        private void dvgStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgStockIn.Columns[e.ColumnIndex].Name;
                
            if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbStock WHERE id='" + dvgStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been successfully deleted.", "POINT OF SALES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

                Loadstockin();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                dgvInstockHistory.Rows.Clear();
                cn.Open();

                cm = new SqlCommand("SELECT * FROM vw_StockIn WHERE Cast(sdate as date) Between '" + dtpFrom.Value.ToShortDateString() + "' AND '" + dtpTo.Value.ToShortDateString() + "' AND status Like 'Done'", cn);

                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    i++;
                    dgvInstockHistory.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[0].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString(), dr["supplier"].ToString());

                }

                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cbsupplier_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbSupplier WHERE supplier LIKE '" + cbsupplier.Text + "%'", cn);
            dr = cm.ExecuteReader();
            if (dr.Read())  // Check if data is returned
            {
                lblId.Text = dr["id"].ToString();
                txtcperson.Text = dr["contact_person"].ToString();
                txtaddress.Text = dr["address"].ToString();
            }
           
            dr.Close();
            cn.Close();
        }

        private void cbsupplier_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
