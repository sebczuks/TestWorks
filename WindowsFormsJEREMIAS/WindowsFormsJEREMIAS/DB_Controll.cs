using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsJEREMIAS
{
    internal class DB_Controll
    {

        static private string _connectionAdress = "Data Source = AsusLaptopRog; Initial Catalog = Shop; Integrated Security = SSPI;";
         
       
        static public SqlConnection _connection = new SqlConnection(_connectionAdress);
        public SqlConnection Connect()
        {
            // Verbindung zur DB herstellen
            try
            {
                _connection.Open();
                MessageBox.Show("DB geöffnet!");
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return _connection;
        }
    }
}

