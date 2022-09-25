using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Media_Experten_Produkte.Model
{
    internal class Mitarbeiter
    {
        public int MitarbeterID { get; set; }

        public string MitarbeterName { get; set; }

        public string MitarbeitrNachname { get; set; }

        public string Abteinung { get; set; }

        public string login { get; set; }
        public string password { get; set; }

        public bool checkLoginWindows(string login, string password)
        {

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kann nicht leer sein");
                return false;

            }
            else
            { return true; }
        }

        public string GetUserName(string login)
        {
            SqlConnection conn = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");
            string sqlgetuserName = "SELECT Name FROM dbo.MitarbieterListe WHERE Login = '" + login + "';";
            SqlCommand commandgetName = new SqlCommand(sqlgetuserName, conn);
            string namefromDB = " ";


            conn.Open();
            try
            {
                using (var reader = commandgetName.ExecuteReader())
                {
                    reader.Read();
                    namefromDB = reader.GetString(0);
                    return namefromDB;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Something went wrong");
                return namefromDB;
            }
            conn.Close();
           

        }
            public bool checkLoginandPassword(string login, string password)
        {

            SqlConnection conn = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");

            if (checkLoginWindows(login, password))
            {
                string sqlgetlogin = "SELECT Login FROM dbo.MitarbieterListe WHERE Login = '" + login + "';";
                string sqlgetpassword = "SELECT Password FROM dbo.MitarbieterListe WHERE Login = '" + login + "';";
                string loginfromDB;
                string passwordfromDB;
                SqlCommand commandgetLogin = new SqlCommand(sqlgetlogin, conn);
                SqlCommand commandgetPassword = new SqlCommand(sqlgetpassword, conn);
                conn.Open();
                try
                {
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Somethings wrong");

                }
                conn.Close();
                if (login == login && password == password)
                { return true; }
                else
                {
                    MessageBox.Show("Falsche eingaben");
                    return false;
                }
            }
            else
            { return false; }










        }



    }
}

