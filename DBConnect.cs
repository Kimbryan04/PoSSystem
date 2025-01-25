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
    }
}
