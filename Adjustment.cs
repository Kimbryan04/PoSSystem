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
    
    public partial class Adjustment : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        MainForm mainForm;
        int _qty;
        public Adjustment(MainForm main)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            mainForm = main;
            LoadStock();
            ReferenceNo();
            lblusername.Text = mainForm.lblusername.Text;

                
        }

        public void ReferenceNo()
        {
            Random rnd = new Random();
            lblrefno.Text = rnd.Next().ToString();
            
        }

        public void LoadStock()
        {
            int i = 0;
            dvgAdjustment.Rows.Clear();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty FROM tbProduct as p INNER JOIN tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory AS c ON c.id = p.cid WHERE CONCAT(p.pdesc, b.brand, c.category) LIKE '%" + txtsearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dvgAdjustment.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

            }

            dr.Close();
            cn.Close();
        }

        private void dvgAdjustment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgAdjustment.Columns[e.ColumnIndex].Name;

            if(colname == "Select")
            {
                lblPcode.Text = dvgAdjustment.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblpDetail.Text = dvgAdjustment.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + dvgAdjustment.Rows[e.RowIndex].Cells[4].Value.ToString() + " " + dvgAdjustment.Rows[e.RowIndex].Cells[5].Value.ToString();
                _qty = int.Parse(dvgAdjustment.Rows[e.RowIndex].Cells[7].Value.ToString());
                btnSave.Enabled = true;

            }

        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            LoadStock();
        }

        public void Clear()
        {
            lblpDetail.Text = "";
            lblPcode.Text = "";
            txtQty.Clear();
            txtRemarks.Clear();
            cbAction.Text = "";
            ReferenceNo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbAction.Text == "")
                {
                    MessageBox.Show("Please select action for add or reduce.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbAction.Focus();
                    return;
                }

                if(txtQty.Text == "")
                {
                    MessageBox.Show("Please input quantity for Add and Reduce.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQty.Focus();
                    return;
                }

                if (txtRemarks.Text == "")
                {
                    MessageBox.Show("Need a reason for Stock Adjustment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRemarks.Focus();
                    return;
                }

                if(int.Parse(txtQty.Text) > _qty && cbAction.Text == "Remove From Inventory")
                {
                    MessageBox.Show("Stock on Hand quantity should be greater than adjustment quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(cbAction.Text == "Remove From Inventory")
                {
                    dbcon.ExecuteQuery("Update tbProduct Set qty = ( qty -" + int.Parse(txtQty.Text) + ") Where pcode like '" + lblPcode.Text + "'");

                }
                else if(cbAction.Text == "Add To Inventory")
                {
                    dbcon.ExecuteQuery("Update tbProduct Set qty = ( qty +" + int.Parse(txtQty.Text) + ") Where pcode like '" + lblPcode.Text + "'");

                }

                dbcon.ExecuteQuery("Insert Into tbAdjustment(referenceno, pcode, qty, action, remarks, sdate, [user]) Values('" + lblrefno.Text + "','" + lblPcode.Text + "','" + int.Parse(txtQty.Text) + "','" + cbAction.Text + "','" + txtRemarks.Text + "','" + DateTime.Now.ToShortDateString() + "','" + lblusername.Text + "')");
                MessageBox.Show("Stock has been successfully adjusted.", "Process completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                btnSave.Enabled = false;
                LoadStock();

            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
