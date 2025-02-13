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
    public partial class Record : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public Record()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadCriticalItems();
        }

        public void LaodTopselling()
        {
            dvgTopSelling.Rows.Clear();
            int i = 0;
            dvgTopSelling.Rows.Clear();
            cn.Open();
            if(cbTopSell.Text == "Sort by Qty")
            {
                cm=new SqlCommand("SELECT TOP 10 pcode, pdesc, ISNULL(SUM(qty), 0) AS qty, ISNULL(SUM(total), 0) AS total from vw_TopSelling where sdate between '" + dtpFrom.Value.ToString()+"' and '"+dtpTo.Value.ToString()+"' and status like 'Sold' Group By pcode, pdesc order by qty desc", cn);
            }
            else if(cbTopSell.Text == "Sort by Total amount")
            {
                cm = new SqlCommand("SELECT TOP 10 pcode, pdesc, ISNULL(SUM(qty), 0) AS qty, ISNULL(SUM(total), 0) AS total from vw_TopSelling where sdate between '" + dtpFrom.Value.ToString() + "' and '" + dtpTo.Value.ToString() + "' and status like 'Sold' Group By pcode, pdesc order by total desc", cn);

            }
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dvgTopSelling.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
            }

            dr.Close();
            cn.Close();
        }

        public void LoadCriticalItems()
        {
            try
            {
                dvgCritical.Rows.Clear();
                int i = 0;
                cn.Open();
                cm = new SqlCommand("Select * From vw_CriticalItems", cn);
                dr = cm.ExecuteReader();
                while(dr.Read())
                {
                    i++;
                    dvgCritical.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());

                }
                dr.Close(); 
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(cbTopSell.Text == "Select sort type")
            {
                MessageBox.Show("Please Select sort type from dropdown list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTopSell.Focus();
                return;
            }
            
            LaodTopselling();
        }

        public void LoadSoldItems()
        {
            try
    {
        dvgSoldItems.Rows.Clear();
        int i = 0;
        cn.Open();

        // Correcting the query to fix GROUP BY and removing the extra single quote
        cm = new SqlCommand("SELECT c.pcode, p.pdesc, SUM(c.qty) AS qty, SUM(c.disc) AS disc, SUM(c.total) AS total " +
                            "FROM tbCart AS c " +
                            "INNER JOIN tbProduct AS p ON c.pcode = p.pcode " +
                            "WHERE status LIKE 'Sold' " +
                            "AND sdate BETWEEN '" + dtSoldItemsFrom.Value.ToString() + "' AND '" + dtSoldItemsTo.Value.ToString() + "' " +
                            "GROUP BY c.pcode, p.pdesc", cn);
        
        dr = cm.ExecuteReader();
        while (dr.Read())
        {
            i++;
            dvgSoldItems.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), 
                                  dr["qty"].ToString(), 
                                  double.Parse(dr["disc"].ToString()).ToString("#,##0.00"), 
                                  double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
        }
        dr.Close();
        cn.Close();

        cn.Open();
        
        cm = new SqlCommand("SELECT ISNULL(SUM(total), 0) FROM tbCart WHERE status LIKE 'Sold' " +
                            "AND sdate BETWEEN '" + dtSoldItemsFrom.Value.ToString() + "' AND '" + dtSoldItemsTo.Value.ToString() + "'", cn);

        lblTotal.Text = double.Parse(cm.ExecuteScalar().ToString()).ToString("#,##0.00");
        cn.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            LoadSoldItems();
        }
    }
}
