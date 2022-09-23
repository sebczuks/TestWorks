using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using Microsoft.EntityFrameworkCore;
using Microsoft.Data;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Media_Experten_Produkte.Model
{
    public class Produkte
    {
        string ProductID { get; set; }

        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCatID { get; set; }
        public string ProductSize { get; set; }

        public int MyProperty { get; set; }



        public DataView ShowProdukteTableforCustomer()
        {
            //This Method will connect to DB and get DataTable with all records

            SqlConnection con = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");
            string sqlString1 = "SELECT * FROM dbo.Produkte";
            var sqlStringforCustomer = "SELECT ProduktName AS 'Name' , ProduktTyp  AS 'Typ' , ProduktProducer AS 'Hersteller' , ProduktPreiss AS 'Preis'   FROM dbo.Produkte";


            // string _connectionString = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                con.Open();

                // MessageBox.Show("Liste unserer Produkte");
                SqlCommand sqlCommand = new SqlCommand(sqlString1, con);
                SqlCommand sqlCommand2 = new SqlCommand(sqlStringforCustomer, con);
                sqlCommand2.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand2);
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

        public DataView ShowProdukteTableafterLogin()
        {
            //This Method will connect to DB and get DataTable with all records

            SqlConnection con = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");
            string sqlString1 = "SELECT * FROM dbo.Produkte";
            var sqlStringforCustomer = "SELECT ProduktName AS 'Produkt Name', ProduktProducer, ProduktPreiss AS 'Produkt Preis' , ProduktTyp  AS 'Produkt Typ'  FROM dbo.Produkte";


            // string _connectionString = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                con.Open();

                MessageBox.Show("Liste unserer Produkte");
                SqlCommand sqlCommand1 = new SqlCommand(sqlString1, con);
                SqlCommand sqlCommand2 = new SqlCommand(sqlStringforCustomer, con);
                sqlCommand1.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand1);
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

        public DataView ShowSearchedResultID(int id)
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

        public DataView Search(string producer, string type, int low, int high) //
        {
            SqlConnection con = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");
            // This Method will search and display in DataView Data
            //check if not empty
            // connect and enforce sql query 

            string sqlQuery = "SELECT * FROM dbo.Produkte WHERE ProduktProducer = ";

           // string sqlselect = "SELECT  'Produkt Name' , 'Produkt Producer', 'Produkt Preis' , 'Produkt Typ', 'ProduktLieferdatum' FROM dbo.Produkte WHERE 'Produkt Producer' = '" + producer + "' AND 'Produkt Typ' = '" + type + "' AND 'Prpdukt Preis' BETEWEN " + preisLow + "AND" + preisHigh + ";";
            string SELECT = "SELECT ProduktName AS 'Produkt Name', ProduktProducer, ProduktPreiss AS 'Produkt Preis' , ProduktTyp  AS 'Produkt Typ'  FROM dbo.Produkte WHERE ProduktPreiss BETWEEN " + low + " AND " + high + " AND  ProduktProducer = '" + producer + "'  AND ProduktTyp = '" + type + "' ;";
            try
            {
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                con.Open();

                // MessageBox.Show("Liste unserer Produkte");
                SqlCommand sqlCommand = new SqlCommand(SELECT, con);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable(SELECT);

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

        public DataView ShowSearchedResultName(string name)
        {
            DataView dataView = new DataView();
            return dataView;
        }

        public DataView ShowSearchedResultProducer(string producer)
        {
            DataView dataView = new DataView();
            return dataView;

        }

        public DataView ShowSearchedResultTyp(string producer)
        {
            DataView dataView = new DataView();
            return dataView;
        }

        public DataView ShowSearchedResultPreisBetween(int low, int high)
        {

            SqlConnection con = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");
            // string sqlString1 = "SELECT * FROM dbo.Produkte Where ProduktID =" + id + ";";
            string sqlString2 = "SELECT * FROM dbo.Produkte Where ProduktPreiss BETWEEN " + low + "AND " + high + ";";


            // string _connectionString = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                con.Open();

                // MessageBox.Show("Liste unserer Produkte");
                SqlCommand sqlCommand = new SqlCommand(sqlString2, con);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable(sqlString2);

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
