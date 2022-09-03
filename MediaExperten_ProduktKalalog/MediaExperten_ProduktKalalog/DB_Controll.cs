using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Data.SqlClient;

namespace MediaExperten_ProduktKalalog
{
    // Here will be connection, login and others Controll and Acsess Points utilytis
    internal class DB_Controll
    {
        //Private Variables
        static public string _connectionAddress = "Data Source=ASUSLAPTOPROG;Initial Catalog=MediaExperten_GmbH;Integrated Security=True;TrustServerCertificate=True";
        static private string _login = "123Test";
        static private string _password = "123Test";

        static SqlConnection _connection = new SqlConnection(_connectionAddress);
        public SqlConnection Connect()
        {
            // Verbindung zur DB herstellen
            try
            {
                _connection.Open();
                MessageBox.Show("DB OPENED");
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return _connection;
        }

       
    }
}
