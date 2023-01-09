using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyCalender.DbModels
{
    public class Users
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Hight { get; set; }
        
        public float Weight { get; set; }
        public string Class { get; set; }
        public string Work { get; set; }


    }
}
