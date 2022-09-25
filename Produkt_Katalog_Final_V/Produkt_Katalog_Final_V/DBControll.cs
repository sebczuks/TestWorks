using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System.Windows;

namespace Produkt_Katalog_Final_V
{
    // This class will open and close connection to DB and will check the Employee login 
    public class DBControll
    {
        public bool loginOk { get; set; }
       // public string connectionString = "Data Source = ASUSLAPTOPROG; Initial Catalog = Shop2; Integrated Security = True; TrustServerCertificate=True";
       public SqlConnection con = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop3;Integrated Security=True;TrustServerCertificate=True");

        public SqlConnection OpenDB()
            {
                try 
                    { 
                        con.Open();
                        MessageBox.Show("DB Opened");
                    }
                catch(Exception EX) 
                    { MessageBox.Show(EX.Message); }
            
                return con;
            }
        
        public void CloseDB()
            { 
                con.Close();
                MessageBox.Show("DB Closed");
        }

        public bool CheckLoginvalues(string login, string password)
            {
            if((login == null || password == null) || (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))) 
                {
                MessageBox.Show("It can not be Empty");
                return false; 
                }

            else 
                {

                return true;
                 }
            }

        public bool CheckLoginOK(string login, string password)
            {
           
            string sqlgetlogin = "SELECT Login FROM dbo.Mitarbeiter WHERE Login = '" + login + "';";
            string sqlgetpassword = "SELECT Password FROM dbo.Mitarbeiter WHERE Login = '" + login + "';";
            string loginfromDB;
            string passwordfromDB;
            SqlCommand commandgetLogin = new SqlCommand(sqlgetlogin, con);
            SqlCommand commandgetPassword = new SqlCommand(sqlgetpassword, con);
            con.Open();
            using (var reader = commandgetLogin.ExecuteReader())
            {
                reader.Read();
                loginfromDB = reader.GetString(0);
            }
            using (var reader2 = commandgetPassword.ExecuteReader())
            {
                reader2.Read();
                passwordfromDB = reader2.GetString(0);


            }

            if (CheckLoginvalues(login,password) == true)
            {
                if(login == loginfromDB && password == passwordfromDB)
               

                loginOk = true;
                return loginOk;
            }
            else
            {
                loginOk = false;
                return loginOk;
            }
            }

    }
}
