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
    public partial class ProductStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        StockIn stockin;
        public ProductStockIn(StockIn stk)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadProduct();
           
            stockin = stk;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadProduct()
        {
            int i = 0;
            dvgProduct.Rows.Clear();
            cm = new SqlCommand("SELECT pcode, pdesc, qty FROM tbProduct where pdesc LIKE '%" + txtsearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dvgProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

            }

            dr.Close();
            cn.Close();

        }

        public void addStockIn(string pcode)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tbStock(refno, pcode, sdate, stockinby, supplierid) VALUES(@refno, @pcode, @sdate, @stockinby, @supplierid)", cn);
                cm.Parameters.AddWithValue("@refno", stockin.txtrefno.Text);
                cm.Parameters.AddWithValue("@pcode", pcode);
                cm.Parameters.AddWithValue("@sdate", stockin.dtpsdate.Value);
                cm.Parameters.AddWithValue("@stockinby", stockin.txtstockin.Text);
                cm.Parameters.AddWithValue("@supplierid", stockin.lblId.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                
                stockin.Loadstockin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "POINT OF SALES");

            }
        }

        private void dvgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgProduct.Columns[e.ColumnIndex].Name;    

            
            
            if (colname == "Select")
            {
               
                if(stockin.txtstockin.Text == string.Empty)
                {
                    MessageBox.Show("Please enter stock in by name", "POINT OF SALES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stockin.txtstockin.Focus();
                    this.Dispose();
                    
                    return;
                }
                if (MessageBox.Show("Add this item?", "POINT OF SALES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    addStockIn(dvgProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                    MessageBox.Show("Item successfully added", "POINT OF SALES");
                }
            }

            LoadProduct();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void ProductStockIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
