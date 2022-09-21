using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows;

namespace Media_Experten_Produkte
{
    
    public class GUIBehavior : MainWindow
    {

       

        public int GetIntValue(int id, string name)
        {
            SqlConnection conn = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            string sqlget = "SELECT " + name + " FROM dbo.Produkte WHERE ProduktID = " + id + ";";
            int get;
            
           
           // strSQL = "SELECT * FROM mitglieder WHERE mitglieds_nr = @mnr;";
            SqlCommand cmd = new SqlCommand(sqlget, conn);
           
           // SqlDataReader reader = cmd.ExecuteReader();
            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                get = reader.GetInt32(0);
            }
            conn.Close();
            return get;

           
            
        }

        public string GetValue (int id, string name)
        {
            SqlConnection conn = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");

            string sqlget = "SELECT " + name + " FROM dbo.Produkte WHERE ProduktID = " + id + ";";
            string set;
            //  string passwordfromDB;
            SqlCommand commandgetname = new SqlCommand(sqlget, conn);
            //SqlCommand commandgetPassword = new SqlCommand(sqlgetpassword, conn);
            conn.Open();
            using (var reader = commandgetname.ExecuteReader())
            {
                reader.Read();
                set = reader.GetString(0);
            }

            conn.Close();
            return set;


        }

   
    }
}
