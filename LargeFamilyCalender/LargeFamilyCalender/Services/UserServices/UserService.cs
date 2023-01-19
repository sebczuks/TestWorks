using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LargeFamilyCalender.Models;

using System.Data;
using LargeFamilyCalender.Services.DbServices;
using Dapper;

namespace LargeFamilyCalender.Services.UserServices
{
    public class UserService
    {

        public void AddUser(User user)
        {
            using (IDbConnection cnn = SqlConnectionService.CraeteFamiliCalenderConnection()) {


             string SQLStr = "INSERT INTO [Users] (Name, DateOfBirth, Height, Weight, Work, Class )" +
                    "           VALUES" +
                                        "( Name As @{nameof(user.Name)}," +
                                        "DateOfBirth As @{user.DateOfBirth}," +
                                        "Height As @{user.Height}," +
                                        "Weight As @{user.Weight}," +
                                        "Work As @{user.Work}," +
                                        "Class As @{user.Class}";

            }

    }
        public int UpdateUserData(User userVariable)
        {
            using (IDbConnection cnn = SqlConnectionService.CraeteFamiliCalenderConnection())
            {


             var SQLStr = $@"INSERT INTO [Users] (Name, DateOfBirth, Height, Weight, Work, Class )" +
                            "VALUES" +
                                 "( Name As @{User.Name)}," +
                                 "DateOfBirth As @{User.DaDateOfBirth)}," +
                                 "Height As @{User.Name)}," +
                                 "Weight As @{User.Weight)}," +
                                 "Work As @{User.Work)}," +
                                 "Class As @{User.Class)}";

                int result = cnn.Execute(SQLStr, userVariable);
                
                return result;

            }
            
        }
    }
}
