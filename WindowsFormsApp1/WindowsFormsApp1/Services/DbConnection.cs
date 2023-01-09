using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace WindowsFormsApp1.Services
{
    public class DbConnection
    {

        public enum DataBaseConnection
        { 
            StockiLaptopKalenderConnection,
            StockiKalenderConnection
        }

        private static readonly string _UserName = "";
        private static readonly string _Passwors = "";

        private static readonly Dictionary<DataBaseConnection, string> _databases = new Dictionary<DataBaseConnection, string>()
        {
            { 
            DataBaseConnection.StockiLaptopKalenderConnection,
            @"Data Source=ASUSLAPTOPROG; Initial Catalog = Kalender; Integrated Security = True; TrustServerCertificate=True"},
            { DataBaseConnection.StockiKalenderConnection,
            @"Server=ASUSLAPTOPROG Database=Kalender;Integrated Security=True;TrustServerCertificate=True"}
        };

        public static IDbConnection CreateLaptopKalenderConnection()
        {
            var cnn = DataBaseConnection.StockiLaptopKalenderConnection;
            return CreateConnection(cnn);
        }

        private static IDbConnection CreateConnection(DataBaseConnection connection)

        {
            var cnn = SqlConnection(connection);
                cnn.Open();
            return cnn;

        }

        private static SqlConnection()
        { 
        
            return new SqlConnection()
        }
            
    }
    
}
