using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeFamilyCalender.Services.DbServices
{
    public class SqlConnectionService  
    {
        public enum DataBaseConnections
        {
            FamiliCalenderConnection,
            ShopConnection,
            LNBauConnection

        }

        private static readonly string _userName = "thisPC";

        internal static IDbConnection CraeteFamiliCalenderConnection()
        {
            throw new NotImplementedException();
        }

        private static readonly string _paasword = "noPassword";
        private static readonly string _dataSource = "ASUSLAPTOPROG";

        private static readonly Dictionary<DataBaseConnections, string> _database = new Dictionary<DataBaseConnections, string>()
        {
            { DataBaseConnections.FamiliCalenderConnection, $"Data Source={_dataSource};Initial Catalog=FamillyCalender;Integrated Security=True;TrustServerCertificate=True"},
            { DataBaseConnections.ShopConnection, "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True"},
            { DataBaseConnections.LNBauConnection, "Data Source=ASUSLAPTOPROG;Initial Catalog=LNBau;Integrated Security=True;TrustServerCertificate=True"}
        };

        //public static IDbConnection CraeteFamiliCalenderConnection()
        //{
        //    var connection = DataBaseConnections.FamiliCalenderConnection;
        //    return CreateConnection(connection);
        //}

        //public static IDbConnection CraeteShopConnection()
        //{
        //    var connection = DataBaseConnections.ShopConnection;
        //    return CreateConnection(connection);
        //}

        //public static IDbConnection CraeteLNBauConnection()
        //{
        //    var connection = DataBaseConnections.LNBauConnection;
        //    return CreateConnection(connection);
        //}
        //public static SqlConnection SqlConnection(DataBaseConnections connection)
        //{
        //    public string Database = _database(connection);
           
        //    return  new SqlConnection(@"Data Source = ASUSLAPTOPROG; Initial Catalog = FamilyCalender; Integrated Security = True; TrustServerCertificate=True");

        //}

        //public static IDbConnection CreateConnection(DataBaseConnections connection)
        //{
        //    var cnn = SqlConnection(connection);
        //    cnn.Open();
        //    return cnn;

        //}


    }
}
