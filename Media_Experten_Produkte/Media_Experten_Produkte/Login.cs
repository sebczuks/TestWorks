using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Media_Experten_Produkte
{
    internal class Login
    {
        public string login { get; set; }
        public string password { get; set; }

        public bool checkLoginWindows(string login, string password)
        {
           
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kann nicht leer sein");
                return false;
             
            }
            else
            { return true; }
        }

        public bool checkLoginandPassword(string login, string password)
        { if( checkLoginWindows(login, password))

             {   if(login == password)
                { return true; }
                else {
                    MessageBox.Show("Falsche eingaben");
                    return false; }
                        }
            else { return false; }


                 }


                
        }
    }
