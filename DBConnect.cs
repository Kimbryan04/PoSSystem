using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class DBConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string con;
        public string MyConnection()
        {
            con = @"Data Source=ASUS-SOLAPTOP\SQLEXPRESS;Initial Catalog=DBPOSale;Integrated Security=True;TrustServerCertificate=True";
            return con;
        }
        
        public DataTable getTable(string qury)
        {
            cn.ConnectionString = MyConnection();
            cm = new SqlCommand(qury, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void ExecuteQuery(string sql)
        {
            try
            {
                cn.ConnectionString = MyConnection();
                cn.Open();
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        public String getPassword(string username)
        {
            string password = "";
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("SELECT password FROM tbUser Where username = '" + username + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();

            if(dr.HasRows)
            {
                password = dr["password"].ToString();
            }
            dr.Close();
            cn.Close();


            return password;
        }

        public double extractData(string sql)
        {
            string sdate = DateTime.Now.ToShortDateString();
            cn = new SqlConnection();
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand(sql, cn);
            double data = double.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return data;

        }
    }
}
