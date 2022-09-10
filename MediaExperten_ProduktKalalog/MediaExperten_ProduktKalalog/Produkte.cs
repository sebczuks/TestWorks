using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;

using System.Data;
using System.Windows;

namespace MediaExperten_ProduktKalalog
{
    internal class Produkte
    {
        public int ProduktID { get; set; }
        public string ProduktName { get; set; }
        public string ProduktSize { get; set; }
        public int ProduktQuantity { get; set; }
        public float ProduktPreis { get; set; }
        public int ProduktType { get; set; }
        public int ProduktLager { get; set; }

        public DateOnly ProduktArrived { get; set; }

        public SqlConnection con = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True");

        public void SerachProductID(SqlConnection con) { return; }
        public System.Data.DataView SerachProductName(SqlConnection con, string produktName)
        {
            
            
                string sqlString = "";
                if ((produktName == "*") || (produktName == ""))
                {
                    sqlString = "SELECT * FROM dbo.Produkte ORDER BY mitglieds_nr ASC;";
                }
                else
                {
                    sqlString = "SELECT * FROM dbo.Produkte WHERE vorname= '" + produktName + "';";
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlString, con);
                    //sqlCommand.Parameters.AddWithValue("@vorname",vorname);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    System.Data.DataTable dataTable = new System.Data.DataTable(sqlString);
                    dataAdapter.Fill(dataTable);
                    return dataTable.DefaultView;
                }
                catch (SqlException error)
                {
                    Console.WriteLine(error.Message);
                    System.Data.DataView dataView = new System.Data.DataView();
                    return dataView;
                }
            }

        public void SerachProductSize(SqlConnection con) { return;  }

        public void SerachProductQuantity(SqlConnection con) { return;  }

        public void SerachProductPreis(SqlConnection con) { return;  }

        public static System.Data.DataView SerachProductType(SqlConnection con, int produktType) 
        
        {

            //try
            //{
            //    MySqlCommand sqlCommand = new MySqlCommand(sqlString, _connection);
            //    //sqlCommand.Parameters.AddWithValue("@vorname",vorname);
            //    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
            //    System.Data.DataTable dataTable = new System.Data.DataTable(sqlString);
            //    dataAdapter.Fill(dataTable);
            //    return dataTable.DefaultView;
            //}
            //catch (MySqlException error)
            //{
            //    Console.WriteLine(error.Message);
            //    System.Data.DataView dataView = new System.Data.DataView();
            //    return dataView;
            //}
           // "SELECT * FROM dbo.Produkte WHERE Produkt" + searchfaktor + "=" + eigenschaft + ";";
            string stringSql = "SELECT * FROM dbo.Produkte WHERE ProduktTyp =" + produktType + ";";

            try
            {
              //  DB_Controll dB_Controll = new DB_Controll();
               //con = dB_Controll.Connect();
              //  con.Open();
               // SqlConnection sqlConnection = new SqlConnection(_connectionString);
                
               
                SqlCommand sqlCommand = new SqlCommand(stringSql, con);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                System.Data.DataTable dataTable = new System.Data.DataTable(stringSql);

                dataAdapter.Fill(dataTable);

               // DataGridProducts.ItemsSource = dataTable.DefaultView;
                dataAdapter.Update(dataTable);
                MessageBox.Show("Deine Produkte nach Typ");
                return dataTable.DefaultView;



                //con.Close();
               // ClearFields();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                System.Data.DataView dataView = new System.Data.DataView();
                return dataView;
            }




            //public void Suchen(MySqlConnection con)
            //{
            //    string strSQL;
            //    MySqlCommand cmd;
            //    Console.WriteLine("Lesen");
            //    strSQL = "SELECT * FROM mitglieder WHERE mitglieds_nr = @mnr;";
            //    cmd = new MySqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@mnr", Mitgliedsnr);
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        this.Vorname = reader["vorname"].ToString();
            //        this.Name = reader["nachname"].ToString();
            //        this.Strasse = reader["strasse"].ToString();
            //        this.Plz = reader["plz"].ToString();
            //        this.Ort = reader["ort"].ToString();
            //        this.Abteilung = reader["abteilung"].ToString();
            //        this.Beitrag = Convert.ToDouble(reader["beitrag"]);
            //    }
            //  reader.Close();


              }






    }


}
