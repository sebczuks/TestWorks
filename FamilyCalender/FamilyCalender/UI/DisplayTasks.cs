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
    public class DisplayTasks
    {

        public static List<Tasks> DisplayTasksList()
        {
            using (IDbConnection con = DBControll.CreateCalenderConnection())
            {

                string sqlString = $@"SELECT Name     
                                     FROM [Tasks] ;";

                return con.Query<Tasks>(sqlString).ToList();
            }

        }
    }
}
