using FamilyCalender.DbModels;
using FamilyCalender.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FamilyCalender.Service
{
    public class TaskService
    {
        public static List<Tasks> GetTaskList()
        {
            using (IDbConnection con = DBControll.CreateCalenderConnection())
            {

                string sqlString = $@"SELECT Name 
                                               
                                              
                                     FROM [Tasks] 
                                        Order By Name ASC;";




                return con.Query<Tasks>(sqlString).ToList();
            }

        }

        public void AddNewTask(int TaskID, int UserID, DateTime DoneAt)
        {
            using (IDbConnection con = DBControll.CreateCalenderConnection())
            {
                string sqlString = $@"INSERT INTO [FamillyCalender].[dbo].[TasksLog]
                                       (
		                               [TaskID], [AssigneeID], [DoneAt]
                                       )
                                 VALUES
                                       (
                                       2,3,'2023-01-05'

                                       )";
                //@TaskID,@UserID, @DoneAt 

                con.Execute(sqlString);
            
            }

        }
    }
}