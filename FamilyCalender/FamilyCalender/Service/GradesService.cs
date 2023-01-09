using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FamilyCalender.Service
{
    public class Service
    {

        public static List<Grades> GetNotesList()
        {
            using (IDbConnection con = DBControll.CreateCalenderConnection())
            {

                string sqlString = $@"SELECT Name     
                                     FROM [Calender].[dbo].[Tasks] ;";

                return con.Query<Grades>(sqlString).ToList();
            }

        }
    }
}
