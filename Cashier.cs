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
    public partial class Cashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point of Sales";
        SqlDataReader dr;

        public Cashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadCashier();
            GetTranNo();
        }

        public void LoadCashier()
        {
            //int i = 0;
            //double total = 0;
            //double discount = 0;

            //dvgCashier.Rows.Clear();
            //cn.Open();
            //cm = new SqlCommand("SELECT c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tbCart as c INNER JOIN tbProduct AS p ON c.pcode = p.pcode WHERE transno LIKE @transno AND c.status LIKE 'Pending' ", cn);
            //cm.Parameters.AddWithValue("@transno", lbltransno.Text);
            //dr = cm.ExecuteReader();

            //while (dr.Read())
            //{
            //    i++;
            //    total += Convert.ToDouble(dr["total"].ToString());
            //    discount += Convert.ToDouble(dr["disc"].ToString());
            //    dvgCashier.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));

            //}


            //dr.Close();
            //cn.Close();
            //lblsalestotal.Text = total.ToString("#,##0.00");
            //lbldisc.Text = discount.ToString("#,##0.00");
            //getCartTotal();

            int i = 0;
            double total = 0;
            double discount = 0;
           
            dvgCashier.Rows.Clear();
            cn.Open();

            cm = new SqlCommand("SELECT c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tbCart as c INNER JOIN tbProduct AS p ON c.pcode = p.pcode WHERE transno LIKE @transno AND c.status LIKE 'Pending' ", cn);
            cm.Parameters.AddWithValue("@transno", lbltransno.Text);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                i++;
                total += Convert.ToDouble(dr["total"].ToString());
                discount += Convert.ToDouble(dr["disc"].ToString());
                dvgCashier.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), double.Parse(dr[6].ToString()).ToString("#,##0.00"));
            }

            

            dr.Close();
            cn.Close();

            // Set the total, discount, VAT, and vatable values to the respective labels
            lblsalestotal.Text = total.ToString("#,##0.00");
            lbldisc.Text = discount.ToString("#,##0.00");
           

            getCartTotal();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void slide(Button button)
        {
            slider.BackColor = Color.White;
            slider.Height = button.Height;
            slider.Top = button.Top;
        }

        private void btntransact_Click(object sender, EventArgs e)
        {
            slide(btntransact);
            GetTranNo();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            slide(btnsearch);
            LookUpProduct lookup = new LookUpProduct(this);
            lookup.LoadProduct();
            lookup.ShowDialog();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            slide(btnadd);
        }

        private void btnsettle_Click(object sender, EventArgs e)
        {
            slide(btnsettle);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            slide(btnclear);
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            slide(btnsales);
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            slide(btnchangepass);
        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to close this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            slide(btnlog);
        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void GetTranNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno;

                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM tbCart WHERE transno LIKE '" + sdate + "%' ORDER BY id desc ", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse((transno.Substring(8, 4)));
                    lbltransno.Text = sdate + (count+1);

                }
                else
                {
                    transno = sdate + "1001";  
                    lbltransno.Text = transno;
                }

                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, stitle);
            }




;        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void getCartTotal()
        {
            double discount = double.Parse(lbldisc.Text);
            double sales = double.Parse(lblsalestotal.Text) - discount;
            double vat = sales * 0.12;
            double vatable = sales - vat;

            lblvat.Text = vat.ToString("#,##0.00");
            lblvatable.Text = vatable.ToString("#,##0.00");
            labeldisplaytotal.Text = sales.ToString("#,##0.00");


        }

        private void labeldisplaytotal_Click(object sender, EventArgs e)
        {

        }
    }

}
