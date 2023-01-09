using FamilyCalender.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FamilyCalender.UI
{
    public class DisplayGrades
    {
        public static List<Grades> DisplayNotesList()
        {
            using (IDbConnection con = DBControll.CreateCalenderConnection())
            {

                string sqlString = $@"SELECT Name     
                                     FROM [Calender].[dbo].[Grades] ;";

                return con.Query<Grades>(sqlString).ToList();
            }

        }
    }
}
