using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CancelForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        DailySales daily;
        public CancelForm(DailySales ds)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            daily = ds;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboaddinv.Text != string.Empty && cancelqty.Value > 0 && txtreason.Text != string.Empty)
                {
                    if(int.Parse(txtqty.Text) >= cancelqty.Value)
                    {
                        Void @void = new Void(this);
                        @void.txtusername.Focus();
                        @void.ShowDialog();
                    }
                }
            }   
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReloadList()
        {
            daily.LoadSold();

        }

        private void cboaddinv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
