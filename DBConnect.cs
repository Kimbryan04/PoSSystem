using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class DBConnect
    {

        private string con;
        public string MyConnection()
        {
            con = @"Data Source=ASUS-SOLAPTOP\SQLEXPRESS;Initial Catalog=DBPOSale;Integrated Security=True;TrustServerCertificate=True";
            return con;
        }
        

    }
}
