using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeFamilyCalender.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DoneAt { get; set; }
        public bool IsCompleted { get; set; }
        public string Type { get; set; }


    }
}
