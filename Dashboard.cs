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
    public partial class Dashboard : Form
    {
        SqlConnection cn = new SqlConnection();
        
        DBConnect dbcon = new DBConnect();
       

        public Dashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadDashBoard();
            
            stonks.Visible = false;
            notStonks.Visible = false;


            if(double.Parse(lblDailySale.Text) == 0)
            {
                notStonks.Visible = true;
            }else
            {
                stonks.Visible = true;
            }
        }

        public void LoadDashBoard()
        {
            string sdate = DateTime.Now.ToShortDateString();
            lblDailySale.Text = dbcon.extractData("Select ISNULL(SUM(total), 0) AS total from tbCart where status Like 'Sold' And sdate between '"+sdate+ "' AND '"+sdate + " '").ToString("#,##0.00");
            lbltotalproduct.Text = dbcon.extractData("Select COunt(*) from tbProduct").ToString("#,##0");
            lblStockOnHand.Text = dbcon.extractData("Select ISNULL(SUM(qty), 0) as qty from tbProduct").ToString("#,##0");
            lblCriticalItems.Text = dbcon.extractData("Select COunt(*) from vw_CriticalItems").ToString("#,##0");

        }
    }
}
