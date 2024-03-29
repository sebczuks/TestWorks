﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows;
using Microsoft.Data.SqlClient;

namespace Media_Experten_Produkte.Model
{
    public class ChangeDB
    {
        DBControll controll = new DBControll();
       
        public void Removerow(int id)
        {
            // This Method will completely remove one row orienting on the id
            //it will be executed after BTN_Remove Button click and ID value comes from TBox_rewRemove
            using SqlConnection con = controll.Connect();
            string sqlremove = "DELETE FROM dbo.Produkte WHERE ProduktID = @ID";
           
            try
            {
                controll.Connect();
                SqlCommand sqlCommand = new SqlCommand(sqlremove, con);
                sqlCommand.Parameters.AddWithValue("@ID", id);
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Daten !");
                }
                else
                {
                    Console.WriteLine("Fehler beim  ändern!");
                }
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Zeile nr " + id + " vollständig gelöscht");
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        public void Addvalues(int produktID, string produktName, string produktProducer, int produktPreis, int produktBestand, int produktType)
        {
            //This Method will take values from TBoxes and 
            string sqlString2 = "INSERT INTO dbo.Produkte (ProduktID, ProduktName, ProduktProducer, ProduktPreiss, ProduktBestend, ProduktType) values ( @produktID, @name , @producer , @preis, @bestand, @type) ";
            using SqlConnection con = controll.Connect();

            try
            {
                controll.Connect();
                SqlCommand sqlCommand = new SqlCommand(sqlString2, con);
                sqlCommand.Parameters.AddWithValue("@produktID", produktID);
                sqlCommand.Parameters.AddWithValue("@name", produktName);
                sqlCommand.Parameters.AddWithValue("@producer", produktProducer);
                sqlCommand.Parameters.AddWithValue("@preis", produktPreis);
                sqlCommand.Parameters.AddWithValue("@bestand", produktBestand);
                sqlCommand.Parameters.AddWithValue("@type", produktType);
               

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Daten erfolgreich hinzügefugt!");
                }
                else
                {
                    Console.WriteLine("Fehler beim  ändern!");
                }
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Insert Succesful");
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        public void Change(int mnr, string name, string producer, int preis, int bestand, string typ)
        {   // This Method will get set of values and update Data Base Produkte
            using SqlConnection con = controll.Connect();
            try
            {

                string sqlString = "UPDATE dbo.Produkte SET ProduktName = @produktName, ProduktProducer = @producer, ProduktPreiss = @preis, ProduktBestend = @bestand, ProduktType = @typ  WHERE ProduktID = @mnr;";
                controll.Connect();
                SqlCommand sqlCommand = new SqlCommand(sqlString, con);
                //string[] values = ("@produktName", "@producer", "@preis", "@bestand", "@typ", "@mnr");
                //string position; 
                //for (int i = 0; i < mnr; i++)
                //    {
                //    sqlCommand.Parameters.AddWithValue(values[i], position);
                //}
                // Parameter mit Werten verkn pfen
                sqlCommand.Parameters.AddWithValue("@produktName", name);
                sqlCommand.Parameters.AddWithValue("@producer", producer);
                sqlCommand.Parameters.AddWithValue("@preis", preis);
                sqlCommand.Parameters.AddWithValue("@bestand", bestand);
                sqlCommand.Parameters.AddWithValue("@typ", typ);
                sqlCommand.Parameters.AddWithValue("@mnr", mnr);

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Daten erfolgreich geändert!");
                }
                else
                {
                    Console.WriteLine("Fehler beim  ändern!");
                }

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        



        }

        public string getSQLqueryr(int id, string[] values)
        {
            string[] produktsproperties = { " ProduktName = ", "ProduktProducer = ", " ProduktPreis", " ProduktPreis", "ProduktTyp" };
            string changeQuery = "UPDATE dbo.Produkte SET ";
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != null)
                {
                    changeQuery = changeQuery + produktsproperties[i] + values[i];



                }


            }
            return changeQuery + " WHERE ProduktID =" + id + ";";
        }


        public string getSQLquery(string name, string producer, int preis, int bestand, string typ)

        // public string getSQLqueryr(string[] values[5])
        { //Method that will get from Tex_Boxes values and will it in SQL Query
          //

            //Check if Text_Boxes are empty
            //Check_if_null(name);
            //Check_if_null(producer);
            //Check_if_null(Convert.ToString(preis));
            //Check_if_null(Convert.ToString(bestand));
            //Check_if_null(typ);
            string changeQuery = "UPDATE dbo.Produkte SET ProduktName = '";
            for (int i = 0; i < 5; i++)
            {
                if (name != null)
                {
                    changeQuery = changeQuery + name;
                    name = producer;
                }
                else
                {

                    name = producer;
                }

            }


            // string changeQuery = "UPDATE dbo.Produkte SET ProduktName = '" + name + "', ProduktProducer = '" + producer + "', ProduktPreis = '" + preis + "', ProduktPreis = '" + bestand + "',ProduktTyp = '" + typ + "'    WHERE ID = ;";
            return changeQuery;
        }
        // Method that will change (1 to n) table content, getting values from TexBoxes and  change them by ID number
        public void changebyID(int id, string changeQuery)
        //
        {
            SqlConnection con = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");
            string sqlString1 = changeQuery + id;


            // string _connectionString = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                con.Open();

                MessageBox.Show("Daten geändert");
                SqlCommand sqlCommand = new SqlCommand(sqlString1, con);
                sqlCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Daten geändert");
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            return;
        }

       
    }

}

