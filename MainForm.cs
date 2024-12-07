using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            MessageBox.Show("Database is Connected");
        }

        public void CustomizeDesign()
        {
            SubPanelProduct.Visible = false;
            SubpanelInstock.Visible = false;
            SubpanelRecord.Visible = false;
            SubpanelSetting.Visible = false;
        }

        public void hidesubmenu()
        {
            if (SubPanelProduct.Visible == true)
            {
                SubPanelProduct.Visible = false;
            }
            if (SubpanelInstock.Visible == true)
            {
                SubpanelInstock.Visible = false;
            }
            if (SubpanelRecord.Visible == true)
            {
                SubpanelRecord.Visible = false;
            }
            if (SubpanelSetting.Visible == true)
            {
                SubpanelSetting.Visible = false;
            }
        }

        public void showsubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnproductlist_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnbrand_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            showsubmenu(SubPanelProduct);
        }

        private void btninstock_Click(object sender, EventArgs e)
        {
            showsubmenu(SubpanelInstock);
        }

        private void btnstockentry_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnstockadj_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnrecord_Click(object sender, EventArgs e)
        {
            showsubmenu(SubpanelRecord);
        }

        private void btnsaleshistory_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnposrecord_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            showsubmenu(SubpanelSetting);
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnstore_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
    }
}
