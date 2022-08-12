using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.EntityFrameworkCore.Tools;

namespace EFDataBaseWPF
{
    internal class DATABASECONTROLL : DbContext
    {
        public string DB { get; set; }
        public string Name { get; set; }  
        public string connectionString { get; set; }



    }
}
