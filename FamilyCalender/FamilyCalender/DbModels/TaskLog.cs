using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyCalender.DbModels
{
    public class TaskLog
    {
        public int Id { get; set; }
        public int AsseigneeID { get; set; }
        public int TaskID { get; set; }
        public DateTime DoneAt { get; set; }
    }
}
