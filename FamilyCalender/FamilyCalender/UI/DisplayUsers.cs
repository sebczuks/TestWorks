using FamilyCalender.DbModels;
using FamilyCalender.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FamilyCalender.UI
{
    public  class DisplayUsers
    {

        public static List<Users> GetUserData(int ID)
        {
            using (IDbConnection con = DBControll.CreateCalenderConnection())
            {
                string sqlString = $@"SELECT  ID As '{nameof(Users.ID)}',
                                                Name AS '{nameof(Users.Name)}',
                                                DateOfBirth AS '{nameof(Users.DateOfBirth)}',
                                                Hight As '{nameof(Users.Hight)}',
                                                Class As {nameof(Users.Class)},
                                                Work As {nameof(Users.Work)},
                                                Weight As {nameof(Users.Weight)} 
                                               
                                     FROM [Users]
                                     WHERE Users.ID = @ID;";


                var param = new { ID };
                return con.Query<Users>(sqlString, param).ToList();
            }

        }

        public static List<Users> UsersNames()
        {
            using (IDbConnection con = DBControll.CreateCalenderConnection())
            {
                string sqlString = $@"SELECT  Name   FROM [Users]";

                return con.Query<Users>(sqlString).ToList();

            }

            }

    }
}
