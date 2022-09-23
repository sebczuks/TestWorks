using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Media_Experten_Produkte.ViewModel
{
    internal class ViewChanger : MainWindow
    {
        public void ShowLoginOK()
        {
            // This Method will make Employee-Buttons visible
            // will be used in MainWindow when LoginButton and loginInput will be correct

            BTN_Add.Visibility = Visibility.Visible;
            BTN_Remove.Visibility = Visibility.Visible;
            BTN_Change.Visibility = Visibility.Visible;
            TBox_rowRemove.Visibility = Visibility.Visible;
            LB_Remove.Visibility = Visibility.Visible;

            LB_Passwort.Visibility = Visibility.Hidden;
            LB_Username.Visibility = Visibility.Hidden;
            TB_Login.Visibility = Visibility.Hidden;
            TB_Password.Visibility = Visibility.Hidden;
            BTN_CheckLogin.Visibility = Visibility.Hidden;
            BTN_Login.Content = "Logout";



        }
    }
}
