using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersRemover.Services
{
    internal class ManageUsers
    {
        public Users Users { get; set; }

        public void AddUser()
        {
          //  IDBConnection 
            Users = new Users();
        }
    }
}
