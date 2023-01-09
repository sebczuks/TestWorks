using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FamilyCalender.Service
{
    public class DBControll
    {

        static private string _connectionAddress = "Data Source=ASUSLAPTOPROG;Initial Catalog=FamillyCalender;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection Connect()
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


        public enum DataBaseConnections
        {
            ASUSROGLAPTOPCalender,
            ASUSROGLAPTOPShop2
            

        }
        private static readonly string _UserName = "";
        private static readonly string _Password = "";

        private static readonly Dictionary<DataBaseConnections, string> _ConnectionMap = new Dictionary<DataBaseConnections, string>()
        {
            {

             DataBaseConnections. ASUSROGLAPTOPCalender,
             @"Data Source=ASUSLAPTOPROG;Initial Catalog=FamillyCalender;Integrated Security=True;"
             },
            {
            DataBaseConnections.ASUSROGLAPTOPShop2,
            @"Data Source=ASUSLAPTOPROG;Initial Catalog=Shop2;Integrated Security=True;"
            }
            };

        private static IDbConnection CreateConnection(DataBaseConnections connection)
       

        
        {
            var conn = SqlConnection(connection);
            conn.Open();
            return conn;
        }

        private static SqlConnection SqlConnection(DataBaseConnections connection)
        {
            string Database = _ConnectionMap[connection];

            return new SqlConnection($"{Database}TrustServerCertificate=True");
        }

        public static IDbConnection CreateCalenderConnection()
        {
            return CreateConnection(DataBaseConnections.ASUSROGLAPTOPCalender);
        }
        public static IDbConnection CreateShop2Connection()
        {
            return CreateConnection(DataBaseConnections.ASUSROGLAPTOPShop2);
        }


        //public DBConnection con = new DBConnection(conString)
        //{ con = new DBConnection()
        //    return 
        //    }

    }
}
