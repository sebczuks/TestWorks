using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System.Windows;

namespace Produkt_Katalog_Final_V
{
    internal class ShowDB : DBControll
    {


       

        public DataView ShowProdukteTable(bool isLoggedIn)
        {
            //This Method will connect to DB and get DataTable with all records

            // SqlConnection con = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");
            string sqlString;
            if (isLoggedIn == true)
                {
                sqlString = "SELECT * FROM dbo.Produkte";
                }
            else
                { 
                sqlString = "SELECT  [Produkt Typ] AS Typ, [Produkt Name] AS Name, [Produkt Producer] AS Hersteller, [Produkt Preis] UVP, [Produkt Lieferdatum] AS LieferDatum, [Produkt ID] FROM [Shop3].[dbo].[Produkte]";
                }
           

            try
            {
                con.Open();

                //// MessageBox.Show("Liste unserer Produkte");
                SqlCommand sqlCommand = new SqlCommand(sqlString, con);
                //SqlCommand sqlCommand2 = new SqlCommand(sqlStringforCustomer, con);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable(sqlString);
                dataAdapter.Fill(dataTable);
              
                return dataTable.DefaultView;
              
            }

            catch (SqlException ex)

            {
                MessageBox.Show(ex.Message);
                DataView dataView = new DataView();
                return dataView;
            }
            con.Close();

        }
    }
}
