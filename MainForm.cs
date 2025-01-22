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
        }

        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lbltitle.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            OpenChildForm(new Product());
            hidesubmenu();
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Category());
            hidesubmenu();
        }

        private void btnbrand_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Brand());
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
            OpenChildForm(new StockIn());
            hidesubmenu();
        }

        private void btnstockadj_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Supplier());
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
            OpenChildForm(new UserAccount());
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
