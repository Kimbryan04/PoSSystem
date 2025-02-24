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
using Zen.Barcode;
using System.Drawing.Imaging;

namespace WindowsFormsApp2
{
    public partial class Barcode : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string fname;
        public Barcode()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dvgBarcode.Rows.Clear();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder FROM tbProduct as p INNER JOIN tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory AS c ON c.id = p.cid WHERE CONCAT(p.pdesc, b.brand, c.category) LIKE '%" + txtsearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dvgBarcode.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

            }

            dr.Close();
            cn.Close();

        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
           
        }

        private void dvgBarcode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dvgBarcode.Columns[e.ColumnIndex].Name;

            if(colname == "Select")
            {
                Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;

                picBarcode.Image = barcode.Draw(dvgBarcode.Rows[e.RowIndex].Cells[2].Value.ToString(), 68, 2);
                fname = dvgBarcode.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Save Barcode Image As";
            saveFile.Filter = "Image file(*.jpg, *.png)| *.jpg, *.png";
            ImageFormat image = ImageFormat.Png;
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                string ftype = System.IO.Path.GetExtension(saveFile.FileName);
                switch (ftype)
                {
                    case ".jpg":
                        image = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        image = ImageFormat.Png;
                        break;


                }

                picBarcode.Image.Save(saveFile.FileName, image);
            }

            picBarcode.Image = null;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
