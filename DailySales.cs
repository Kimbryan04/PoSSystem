﻿using System;
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
    public partial class DailySales : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public DailySales()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadCashier();
            LoadSold();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCashier()
        {
           cbCashier.Items.Clear();
           cbCashier.Items.Add("All Cashier");
           cn.Open();

            cm = new SqlCommand("Select * From tbUser Where role = 'Cashier'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbCashier.Items.Add((string)dr["username"].ToString());
            }
            dr.Close();
            cn.Close();
            

        }

        public void LoadSold()
        {
            int i = 0;
            double total = 0;
            dvgSold.Rows.Clear();
            cn.Open();

            if(cbCashier.Text == "All Cashier")
            {
               
                cm = new SqlCommand("Select c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total from tbCart as c inner join tbProduct as p on c.pcode = p.pcode where c.status like 'Sold' and c.sdate between  '" + dtpFrom.Value + "' and '" + dtpTo.Value + " '", cn);

            }
            else
            {
                cm = new SqlCommand("Select c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total from tbCart as c inner join tbProduct as p on c.pcode = p.pcode where c.status like 'Sold' and c.sdate between  '" + dtpFrom.Value + "' and '" + dtpTo.Value + "' and c.cashier = '" + cbCashier.Text + " '", cn);

            }
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                total += double.Parse(dr["total"].ToString());
                dvgSold.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());
            }
            dr.Close();
            cn.Close();
            lblTotal.Text = total.ToString("#,##0.00");

        }

        private void cbCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void DailySales_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
