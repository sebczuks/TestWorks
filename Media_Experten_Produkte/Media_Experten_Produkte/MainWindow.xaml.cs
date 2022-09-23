




using Media_Experten_Produkte.Model;
using Media_Experten_Produkte.ViewModel;
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

        public void HideLogin()
        {
            LB_Passwort.Visibility = Visibility.Hidden;
            LB_Username.Visibility = Visibility.Hidden;
            TB_Login.Visibility = Visibility.Hidden;
            TB_Password.Visibility = Visibility.Hidden;
            BTN_CheckLogin.Visibility = Visibility.Hidden;
            BTN_Add.Visibility = Visibility.Hidden;
            BTN_Remove.Visibility = Visibility.Hidden;
            BTN_Change.Visibility = Visibility.Hidden;
            TBox_rowRemove.Visibility = Visibility.Hidden;
            LB_Remove.Visibility = Visibility.Hidden;
            LB_Dubistals.Visibility = Visibility.Hidden;
            LB_UserNameMainWindow.Visibility = Visibility.Hidden;

        }

        public void ShowLogin()
        {
            LB_Passwort.Visibility = Visibility.Visible;
            LB_Username.Visibility = Visibility.Visible;
            TB_Login.Visibility = Visibility.Visible;
            TB_Password.Visibility = Visibility.Visible;
            BTN_CheckLogin.Visibility = Visibility.Visible;
          

        }


        public void ShowifLoginOK()
        {  
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
            LB_UserNameMainWindow.Visibility = Visibility.Visible;
            LB_Dubistals.Visibility = Visibility.Visible;
            BTN_Login.Content = "Logout";



        }

        Mitarbeiter checkLoginandPassword = new Mitarbeiter();
        Login loginchecker = new Login();
        Produkte pr = new Produkte();
        WindowsInteraction checkLogin = new WindowsInteraction();
        ChangeDB remover = new ChangeDB(); 
     //   ViewChanger changer = new ViewChanger();
       
        public MainWindow()
        {
           

            InitializeComponent();
            DG_Produkte.ItemsSource = pr.ShowProdukteTableforCustomer();
            DG_Produkte.FontSize = 18;


            HideLogin();


        }

       

        private void BTN_ShowProdukte_Click_1(object sender, RoutedEventArgs e)
        {
            DG_Produkte.ItemsSource = pr.ShowProdukteTableafterLogin();

        }

        private void BTN_SearchbyID_Click(object sender, RoutedEventArgs e)
        {
           
            int id = int.Parse(TBox_SearchID.Text);

            DG_Produkte.ItemsSource = pr.ShowSearchedResultID(id);

        }




        private void BTN_LoginMainWindow_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow LogIn = new LoginWindow();
            LogIn.Show();    

        }

   

        private void BTN_Login_Click(object sender, RoutedEventArgs e)
        {
            ShowLogin();
      
            
        }

    

        private void BTN_SearchbyPreis_Click(object sender, RoutedEventArgs e)
        {
            int low = int.Parse(TBox_SearchPreisLow.Text);
            int high = int.Parse(TBox_SearchPreisHigh.Text);
            DG_Produkte.ItemsSource = pr.ShowSearchedResultPreisBetween(low, high);

        }

        private void BTN_SearchbyTyp_Click(object sender, RoutedEventArgs e)
        {

            DG_Produkte.ItemsSource = pr.Search(CBox_Producers.Text, CBox_Types.Text, int.Parse(TBox_SearchPreisLow.Text), int.Parse(TBox_SearchPreisHigh.Text) );
        }

        private void BTN_SearchbyProducer_Click(object sender, RoutedEventArgs e)
        {
            string CBoxvalue1, CBoxvalue2;
            CBoxvalue1 = CBox_Producers.Text;
            CBoxvalue2 = CBox_Types.Text;
            MessageBox.Show(CBoxvalue1 +  CBoxvalue2);
        


        }

        private void BTN_SearchbyName_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_CheckLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = TB_Login.Text;
            string password = TB_Password.Text;
          //  string password = PBox_password.Text;
            //MessageBox.Show(login);
            //if(login == password)
            //{
            //    BTN_Add.Visibility = Visibility.Visible;
            //    //     BTN_Remove.Visibility = Visibility.Visible;

            //}
            //else { MessageBox.Show("Wrong"); };


           if( loginchecker.CheckLoginandPassword(login, password))
            {
              ShowifLoginOK(); 
             

            }
            else 
            { return;  };



            //LB_Passwort.Visibility = Visibility.Visible;
            //LB_Username.Visibility = Visibility.Visible;
            //TB_Login.Visibility = Visibility.Visible;
            //TB_Password.Visibility = Visibility.Visible;
            //BNT_CheckLogin.Visibility = Visibility.Visible;

        }

       

        private void ListBProducerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void BTN_Change_Click(object sender, RoutedEventArgs e)
        {
            ChangeWindow changeWindow = new ChangeWindow();
            changeWindow.Show();

        }

        private void BTN_Remove_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(TBox_rowRemove.Text);
            remover.Removerow(id);
        }

        private void BTN_Add_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
        }

       
    }
}

