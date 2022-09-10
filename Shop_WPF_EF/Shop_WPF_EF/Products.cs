using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Shop_WPF_EF
{
    public class Products
    {
        string ProductID { get; set; }

        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCatID { get; set; }
        public string ProductSize { get; set; }

        public int MyProperty { get; set; }

        public void Remove(string what, int position)
        {
            if (position == 0)
            {
                ProductCatID = 0; ProductSize = null;
            }
            else
            {
               
                MessageBox.Show("NO");

            }

        }

        public DataView ShowProdukteTable ( )
        {

            SqlConnection con = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");
            string sqlString1 = "SELECT * FROM dbo.Produkte";


            // string _connectionString = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                con.Open();

                MessageBox.Show("Liste unserer Produkte");
                SqlCommand sqlCommand = new SqlCommand(sqlString1, con);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable(sqlString1);

                dataAdapter.Fill(dataTable);
                return dataTable.DefaultView;
               
             



                con.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                DataView dataView = new DataView();
                return dataView;
            }

        }

        public DataView ShowSearchedRecord(int id)
        {
            SqlConnection con = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");
            string sqlString1 = "SELECT * FROM dbo.Produkte Where ProduktID =" + id + ";";


            // string _connectionString = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                con.Open();

               // MessageBox.Show("Liste unserer Produkte");
                SqlCommand sqlCommand = new SqlCommand(sqlString1, con);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable(sqlString1);

                dataAdapter.Fill(dataTable);
                return dataTable.DefaultView;





                con.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                DataView dataView = new DataView();
                return dataView;
            }

        }
    }
}
