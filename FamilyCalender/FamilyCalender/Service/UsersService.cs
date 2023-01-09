using FamilyCalender.DbModels;
using FamilyCalender.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static FamilyCalender.Service.DBControll;

namespace FamilyCalender.Service
{
    public class UsersService : Users
    {

        public IEnumerable<Users> AddOneUserName()
        {
            using (DBControll.Connect())
                return null;
                    }
  //          {

  //              private string SqlAllUsers = "SELECT [ID] As 
  //    ,[DateOfBirth]
  //    ,[Name]
  //    ,[Hight]
  //    ,[Class]
  //    ,[Work]
  //    ,[Weight]
  //    ,[PiontsThisMonth]
  //    ,[PiontsTotal]
  //FROM[Calender].[dbo].[Users]"
  //              try { 
                
  //                  }
  //              catch {
                        
  //                    }


  //          }
  //      return null;
  //      }

  //      public IEnumerable<Users> GetAllUsers()
  //      {

        }


    }

