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
    public partial class Void : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        CancelForm cancel;
        public Void(CancelForm can)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            txtusername.Focus();
            cancel = can;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text == cancel.txtcancel.Text)
                {
                    MessageBox.Show("Void by and Cancel by are the same, Please Enter Another person", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                string user;
                cn.Open();
                cm = new SqlCommand("Select * from tbUser where username = @username And password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtusername.Text);
                cm.Parameters.AddWithValue("@password", txtpass.Text);
                dr = cm.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    user = dr["username"].ToString();
                    dr.Close();
                    cn.Close();
                    SaveCancelOrder(user);
                    if (cancel.cboaddinv.Text == "Yes")
                    {
                        dbcon.ExecuteQuery("Update tbProduct set qty = qty -" + cancel.cancelqty.Value + "where pcode= '" + cancel.txtpcode.Text + " '");
                    }
                    dbcon.ExecuteQuery("Update tbCart set qty = qty -" + cancel.cancelqty.Value + "where id='" + cancel.txtid.Text + " '");

                    MessageBox.Show("Order transaction successfully cancelled!", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    cancel.ReloadList();
                    cancel.Dispose();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void SaveCancelOrder(string user)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Insert Into tbCancel(transno, pcode, price, qty, total, sdate, voidby, cancelledby, reason, action) Values(@transno, @pcode, @price, @qty, @total, @sdate, @voidby, @cancelledby, @reason, @action)", cn);
                cm.Parameters.AddWithValue("@transno", cancel.txttransno.Text);
                cm.Parameters.AddWithValue("@pcode", cancel.txtpcode.Text);
                cm.Parameters.AddWithValue("@price", double.Parse(cancel.txtprice.Text));
                cm.Parameters.AddWithValue("@qty", int.Parse(cancel.txtqty.Text));
                cm.Parameters.AddWithValue("@total", int.Parse(cancel.txtqty.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@voidby", user);
                cm.Parameters.AddWithValue("@cancelledby", cancel.txtcancel.Text);
                cm.Parameters.AddWithValue("@reason", cancel.txtreason.Text);
                cm.Parameters.AddWithValue("@action", cancel.cboaddinv.Text);
                cm.ExecuteNonQuery();
                cn.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
