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
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp2
{
    public partial class Receipt : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string store;
        string address;
        Cashier cashier;
        public Receipt(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cashier = cash;
            LoadStore();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

        public void LoadStore()
        {
            cn.Open();
            cm = new SqlCommand("Select * From tbStore", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows){
                store = dr["store"].ToString();
                address = dr["address"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        public void LoadReceipt(string pcash, string pchange)
        {
            ReportDataSource rptDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptReceipt.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();

                da.SelectCommand = new SqlCommand("Select c.id, c.transno, c.pcode, c.price, c.qty, c.disc, c.total, c.sdate, c.status, p.pdesc From tbCart AS c Inner Join tbProduct as p ON p.pcode = c.pcode Where transno Like '" + cashier.lbltransno.Text + "'", cn);
                da.Fill(ds.Tables["DtReceipt"]);
                cn.Close();

                ReportParameter pVatable = new ReportParameter("pVatable", cashier.lblvatable.Text);
                ReportParameter pVat = new ReportParameter("pVAT", cashier.lblvat.Text);
                ReportParameter pDiscount = new ReportParameter("pDiscount", cashier.lbldisc.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", cashier.lblsalestotal.Text);
                ReportParameter pCash = new ReportParameter("pCash", pcash);
                ReportParameter pChange = new ReportParameter("pChange", pchange);
                ReportParameter pStore = new ReportParameter("pStore", store);
                ReportParameter pAddress = new ReportParameter("pAddress",address);
                ReportParameter pTransaction = new ReportParameter("pTransaction", cashier.lbltransno.Text);
                ReportParameter pCashier = new ReportParameter("pCashier", cashier.lblusername.Text);

                reportViewer1.LocalReport.SetParameters(pVatable);
                reportViewer1.LocalReport.SetParameters(pVat);
                reportViewer1.LocalReport.SetParameters(pDiscount);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pCash);
                reportViewer1.LocalReport.SetParameters(pChange);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);
                reportViewer1.LocalReport.SetParameters(pTransaction);
                reportViewer1.LocalReport.SetParameters(pCashier);

                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["DtReceipt"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 30;

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Receipt_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
