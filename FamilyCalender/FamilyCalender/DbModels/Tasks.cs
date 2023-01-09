using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyCalender.DbModels
{
    public class Tasks
    {
        public int ID { get; set; }
        public int CateroryID { get; set; }
        public string Name { get; set; }


        public string Description { get; set; }
        public string Shortcut { get; set; }



    }
}
