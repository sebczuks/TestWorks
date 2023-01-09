using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoccyCalender.OutPut
{
    internal class Tasks
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        // Here comes one objeck from class Category
        public Category category =  new Category();

        public DateTime CreatedAt;

    public DateTime DoneAt;
public bool IsDone { get; set; }
    }

}
