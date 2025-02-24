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
    public partial class Discount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        Cashier cashier;
        
        public Discount(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cashier = cash;
            txtdiscount.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Discount_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Escape) this.Dispose();
            else if (e.KeyCode == Keys.Enter) btnconfirm.PerformClick();
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double disc = double.Parse(txtttlprice.Text) * double.Parse(txtdiscount.Text) * 0.01;
                txtdiscamount.Text = disc.ToString("#,##0.00");

            }
            catch (Exception)
            {

                txtdiscamount.Text = "0.00"; 
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Add discount? Click yes to confirm", "POINT OF SALES", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tbCart SET disc_percent=@disc_percent WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@id", int.Parse(lblid.Text));
                    cm.Parameters.AddWithValue("@disc_percent", double.Parse(txtdiscount.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();
                    cashier.LoadCashier();
                    this.Dispose();
                    
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "POINT OF SALES");
            }
        }
    }
}
