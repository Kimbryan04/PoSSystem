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
using ZXing;
using DarrenLee.Media;

namespace WindowsFormsApp2
{
    public partial class Cashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point of Sales";
        SqlDataReader dr;
        int qty;
        string id;
        string price;

        Camera captureDevice = new Camera();
        public Cashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadCashier();
            GetTranNo();
            lbldate.Text = DateTime.Now.ToShortDateString();
           

        }

        public void LoadCashier()
        {
            try
            {
                Boolean hascart = false;
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
                    hascart = true;
                }



                dr.Close();
                cn.Close();

                // Set the total, discount, VAT, and vatable values to the respective labels
                lblsalestotal.Text = total.ToString("#,##0.00");
                lbldisc.Text = discount.ToString("#,##0.00");


                getCartTotal();

                if(hascart) {btnclear.Enabled = true; btnsettle.Enabled = true; btnadd.Enabled = true; }
                else { btnclear.Enabled = false; btnsettle.Enabled = false; btnadd.Enabled = false; }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "POINT OF SALES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

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
            Discount discount = new Discount(this);
            discount.lblid.Text = id;
            discount.txtttlprice.Text = price;
            discount.ShowDialog();
        }

        private void btnsettle_Click(object sender, EventArgs e)
        {
            
            slide(btnsettle);
            Settle settle = new Settle(this);
            settle.txtSale.Text = lblsalestotal.Text;
            settle.ShowDialog();    
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            slide(btnclear);

            if(MessageBox.Show("Remove all items from cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("Delete from tbCart where transno like @transno", cn);
                cm.Parameters.AddWithValue("@transno", lbltransno.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("All  items has been successfully remove", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCashier();
                    
            }
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            slide(btnsales);
            DailySales daily = new DailySales();
            daily.solduser = lblusername.Text;
            daily.dtpTo.Enabled = false;
            daily.dtpFrom.Enabled = false;
            daily.cbCashier.Enabled = false;
            daily.cbCashier.Text = lblusername.Text;
            daily.picCLose.Visible = true;
            daily.lblTitle.Visible = true;
            daily.ShowDialog();

        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            slide(btnchangepass);
            ChangePassword change = new ChangePassword(this);
            change.ShowDialog();

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
            if(dvgCashier.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout. Please cancel the transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (MessageBox.Show("Exit Apllication?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();

            }
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
            double sales = double.Parse(lblsalestotal.Text) - discount;  // Apply the discount to sales total
            double vat = sales * 0.12;
            double vatable = sales - vat;

            lblvat.Text = vat.ToString("#,##0.00");
            lblvatable.Text = vatable.ToString("#,##0.00");
            labeldisplaytotal.Text = lblsalestotal.Text;


        }

        private void labeldisplaytotal_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string _pcode;
            double _price;
            int _qty;

            try
            {
                cn.Open();

                // Use parameterized query to avoid SQL injection
                cm = new SqlCommand("SELECT * FROM tbProduct WHERE barcode LIKE @barcode", cn);
                cm.Parameters.AddWithValue("@barcode", textBox1.Text + "%");
                dr = cm.ExecuteReader();


                if (dr.Read())
                {
                    qty = int.Parse(dr["qty"].ToString());
                    _pcode = dr["pcode"].ToString();
                    _price = double.Parse(dr["price"].ToString());
                    _qty = int.Parse(txtqty.Text);


                    dr.Close();
                    cn.Close();

                    AddToCart(_pcode, _price, _qty);

                }
                else
                {
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "POINT OF SALES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        public void AddToCart(string _pcode, double _price, int _qty)
        {
            try
            {
                string id = "";
                int cart_qty = 0;
                bool found = false;

                cn.Open();

                cm = new SqlCommand("SELECT * FROM tbcart WHERE transno = @transno AND pcode = @pcode", cn);
                cm.Parameters.AddWithValue("@transno", lbltransno.Text);
                cm.Parameters.AddWithValue("@pcode", _pcode);
                dr = cm.ExecuteReader();
                dr.Read();

                if (dr.HasRows) // Check if record exists
                {
                    id = dr["id"].ToString();
                    cart_qty = int.Parse(dr["qty"].ToString());
                    found = true;
                }

                dr.Close();
                cn.Close();

                if (found)
                {
                    // Check stock quantity
                    if (qty < (cart_qty + _qty))
                    {
                        MessageBox.Show("Unable to proceed. Remaining quantity on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cn.Open();
                    cm = new SqlCommand("UPDATE tbCart SET qty = qty + @qty WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@qty", _qty);
                    cm.Parameters.AddWithValue("@id", id);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    textBox1.SelectionStart = 0;
                    textBox1.SelectionLength = textBox1.Text.Length;
                    LoadCashier();
                }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbCart (transno, pcode, price, qty, sdate, cashier) VALUES (@transno, @pcode, @price, @qty, @sdate, @cashier)", cn);
                    cm.Parameters.AddWithValue("@transno", lbltransno.Text);
                    cm.Parameters.AddWithValue("@pcode", _pcode);
                    cm.Parameters.AddWithValue("@price", _price);
                    cm.Parameters.AddWithValue("@qty", _qty);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.Parameters.AddWithValue("@cashier", lblusername.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadCashier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "POINT OF SALES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        private void dvgCashier_SelectionChanged(object sender, EventArgs e)
        {
            int i = dvgCashier.CurrentRow.Index;
            id = dvgCashier[1, i].Value.ToString();
            price = dvgCashier[7, i].Value.ToString();

        }

        private void dvgCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgCashier.Columns[e.ColumnIndex].Name;
          


            if (colname == "Delete")
            {
                if (MessageBox.Show("Remove this Item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.ExecuteQuery("Delete from tbCart where id like '" + dvgCashier.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");

                    MessageBox.Show("item has been successfully remove", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCashier();

                }
            }
            else if (colname == "colAdd")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT SUM(qty) AS qty FROM tbProduct WHERE pcode LIKE @pcode GROUP BY pcode", cn);
                cm.Parameters.AddWithValue("@pcode", dvgCashier.Rows[e.RowIndex].Cells[2].Value.ToString());
                i = Convert.ToInt32(cm.ExecuteScalar());  // Using Convert.ToInt32() for better handling
                cn.Close();


                if (int.Parse(dvgCashier.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                {
                    // Use parameterized query to prevent SQL injection and syntax errors
                    string query = "UPDATE tbCart SET qty = qty + @qty WHERE transno LIKE @transno AND pcode LIKE @pcode";

                    // Prepare the command and add parameters
                    cm = new SqlCommand(query, cn);
                    cm.Parameters.AddWithValue("@qty", int.Parse(txtqty.Text)); // Value for qty
                    cm.Parameters.AddWithValue("@transno", lbltransno.Text);    // Value for transno
                    cm.Parameters.AddWithValue("@pcode", dvgCashier.Rows[e.RowIndex].Cells[2].Value.ToString()); // Value for pcode

                    // Open connection, execute query, and close connection
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadCashier();
                }
                else
                {
                    MessageBox.Show("Remaining qty on hand is " + i + "!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else if (colname == "colReduce")
            {
                int currentQty = 0;

                // Retrieve the current quantity from tbCart for the product
                string query = "SELECT SUM(qty) AS qty FROM tbCart WHERE pcode LIKE @pcode AND transno LIKE @transno";
                cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@pcode", dvgCashier.Rows[e.RowIndex].Cells[2].Value.ToString());
                cm.Parameters.AddWithValue("@transno", lbltransno.Text);  // Use the correct transno

                cn.Open();
                currentQty = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                // Check if there's enough quantity to reduce
                if (currentQty > int.Parse(txtqty.Text))  // Make sure we don't go below zero
                {
                    // Proceed with reducing the quantity in the cart
                    string updateQuery = "UPDATE tbCart SET qty = qty - @qty WHERE transno LIKE @transno AND pcode LIKE @pcode";

                    // Prepare the command with parameters
                    cm = new SqlCommand(updateQuery, cn);
                    cm.Parameters.AddWithValue("@qty", int.Parse(txtqty.Text)); // Reduction value
                    cm.Parameters.AddWithValue("@transno", lbltransno.Text);    // Transno for the cart
                    cm.Parameters.AddWithValue("@pcode", dvgCashier.Rows[e.RowIndex].Cells[2].Value.ToString()); // Pcode for the item

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadCashier();  // Refresh the cashier data
                }
                else
                {
                    // Show a message if the remaining quantity is not enough to reduce
                    MessageBox.Show("Cannot reduce the quantity below zero. Current quantity in cart is " + currentQty + "!",
                                    "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


        }

        private void dvgCashier_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F8)
            {
                captureDevice.OnFrameArrived += captureDevice_OnFrameArrived;
                captureDevice.Start();
            }
             
        }

        private void captureDevice_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {

            if (e == null)
            {
                MessageBox.Show("Null Image", "Null");
            }
            else
            {
                Bitmap bitmap = (Bitmap)e.GetFrame();
                if (bitmap != null)
                {
                    BarcodeReader barcodeReader = new BarcodeReader();
                    var result = barcodeReader.Decode(bitmap);

                    if (result != null)
                    {
                        textBox1.Invoke(new MethodInvoker(delegate ()
                        {
                            textBox1.Text = result.ToString(); // Use result.Text instead of result.ToString()
                        }));
                    }
                }
            }
           
        }


        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
          captureDevice.Stop();   
        }
    }

}
