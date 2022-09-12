




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;




namespace Media_Experten_Produkte
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
        Login loginchecker = new Login();
        Produkte pr = new Produkte();
        WindowsInteraction checkLogin = new WindowsInteraction();
        public MainWindow()
        {
            //static void HideLogin()
            //{
            //LB_Passwort.Visibility = Visibility.Hidden;
            //LB_Username.Visibility = Visibility.Hidden;
            //TB_Login.Visibility = Visibility.Hidden;
            //TB_Password.Visibility = Visibility.Hidden;
            //BNT_CheckLogin.Visibility = Visibility.Hidden;

            //}

            InitializeComponent();

            LB_Passwort.Visibility = Visibility.Hidden;
            LB_Username.Visibility = Visibility.Hidden;
            TB_Login.Visibility = Visibility.Hidden;
            TB_Password.Visibility = Visibility.Hidden;
            BNT_CheckLogin.Visibility = Visibility.Hidden;
            BTN_Add.Visibility = Visibility.Hidden;
            BTN_Remove.Visibility = Visibility.Hidden;



            if ( checkLogin.loginOK == true)
          
            {
               // BTN_Change.Visibility = Visibility.Visible;

            }
                else
            {
               // BTN_Change.Visibility = Visibility.Hidden;


            }
        }

       

        private void BTN_ShowProdukte_Click_1(object sender, RoutedEventArgs e)
        {
            DG_Produkte.ItemsSource = pr.ShowProdukteTable();

        }

        private void BTN_SearchbyID_Click(object sender, RoutedEventArgs e)
        {
            //if(Not int)
            //{
            //    MessageBox.Show("Es mus ien Gaznzahl sein");

            //}
            //else
            //{ }

            int id = int.Parse(TBox_SearchID.Text);

            DG_Produkte.ItemsSource = pr.ShowSearchedResultID(id);

        }




        private void BTN_LoginMainWindow_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow LogIn = new LoginWindow();
            LogIn.Show();
            
            

        }

   

        private void BNT_Login_Click(object sender, RoutedEventArgs e)
        {
            LB_Passwort.Visibility = Visibility.Visible;
            LB_Username.Visibility = Visibility.Visible;
            TB_Login.Visibility = Visibility.Visible;
            TB_Password.Visibility = Visibility.Visible;
            BNT_CheckLogin.Visibility = Visibility.Visible;
          

        }

    

        private void BTN_SearchbyPreis_Click(object sender, RoutedEventArgs e)
        {
            int low = int.Parse(TBox_SearchPreisLow.Text);
            int high = int.Parse(TBox_SearchPreisHigh.Text);
            DG_Produkte.ItemsSource = pr.ShowSearchedResultPreisBetween(low, high);

        }

        private void BTN_SearchbyTyp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_SearchbyProducer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_SearchbyName_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BNT_CheckLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = TB_Login.Text;
            string password = TB_Password.Text;
            //MessageBox.Show(login);
            //if(login == password)
            //{
            //    BTN_Add.Visibility = Visibility.Visible;
            //    //     BTN_Remove.Visibility = Visibility.Visible;

            //}
            //else { MessageBox.Show("Wrong"); };
           if( loginchecker.checkLoginandPassword(login, password))
            {
                BTN_Add.Visibility = Visibility.Visible;
                BTN_Remove.Visibility = Visibility.Visible;
            }
            else { return;  };



            //LB_Passwort.Visibility = Visibility.Visible;
            //LB_Username.Visibility = Visibility.Visible;
            //TB_Login.Visibility = Visibility.Visible;
            //TB_Password.Visibility = Visibility.Visible;
            //BNT_CheckLogin.Visibility = Visibility.Visible;

        }
    }
}

