using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows;

namespace Media_Experten_Produkte
{
    public class DBControll
    {

        static private string _connectionAddress = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;TrustServerCertificate=True";
      
        public SqlConnection Connect()
        {
            // Verbindung zur DB herstellen
            try
            {
                SqlConnection connection = new SqlConnection(_connectionAddress);
                connection.Open();
                
                return connection;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

      






        }



    
}
