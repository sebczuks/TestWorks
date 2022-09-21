using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Media_Experten_Produkte.Model
{
    internal class Login
    {
        public string login { get; set; }
        public string password { get; set; }

        public bool CheckLoginWindows(string login, string password)
        {

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kann nicht leer sein");
                return false;

            }
            else
            { return true; }
        }

        public bool CheckLoginandPassword(string login, string password)
        {
            SqlConnection conn = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True");

            string sqlgetlogin = "SELECT Login FROM dbo.MitarbieterListe WHERE Login = '" + login + "';";
            string sqlgetpassword = "SELECT Password FROM dbo.MitarbieterListe WHERE Login = '" + login + "';";
            string loginfromDB;
            string passwordfromDB;
            SqlCommand commandgetLogin = new SqlCommand(sqlgetlogin, conn);
            SqlCommand commandgetPassword = new SqlCommand(sqlgetpassword, conn);
            conn.Open();
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
            if (CheckLoginWindows(login, password))

            {
                if (login == loginfromDB && password == passwordfromDB)
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
