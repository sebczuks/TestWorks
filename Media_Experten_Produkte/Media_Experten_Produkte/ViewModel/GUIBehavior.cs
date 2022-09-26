using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows;

namespace Media_Experten_Produkte.ViewModel
{
   
    public class GUIBehavior : MainWindow
    {
        DBControll controll = new DBControll();



        public int GetIntValue(int id, string name)
        {
            using SqlConnection con = controll.Connect();
            string sqlget = "SELECT "+ name +" FROM dbo.Produkte WHERE ProduktID = " + id +";";
            int get;
            controll.Connect();

            // strSQL = "SELECT * FROM mitglieder WHERE mitglieds_nr = @mnr;";
            SqlCommand cmd = new SqlCommand(sqlget, con);
            //cmd.Parameters.AddWithValue("@name", name);
            //cmd.Parameters.AddWithValue("@id", id);
            

            // SqlDataReader reader = cmd.ExecuteReader();
            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                get = reader.GetInt32(0);
            }
          
            return get;



        }

        public string GetValue(int id, string name)
        {
            // This Method will update T_Box Text on TBox Event

            using SqlConnection con = controll.Connect();
            string sqlget = "SELECT @name FROM dbo.Produkte WHERE ProduktID = @id;";
            string get;
            controll.Connect();
            //  string passwordfromDB;
            SqlCommand commandget = new SqlCommand(sqlget, con);
           
            commandget.Parameters.AddWithValue("@name", name);
            commandget.Parameters.AddWithValue("@id", id);
            //SqlCommand commandgetPassword = new SqlCommand(sqlgetpassword, conn);

            using (var reader = commandget.ExecuteReader())
            {
                reader.Read();
                get = reader.GetString(0);
            }

       
            return get;


        }


    }
}
