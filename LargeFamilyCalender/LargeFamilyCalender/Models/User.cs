using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeFamilyCalender.Models
{
     public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Work { get; set; }
         public string Class { get; set; }
        //public bool IsAdoult { get; set; }
    }
}
