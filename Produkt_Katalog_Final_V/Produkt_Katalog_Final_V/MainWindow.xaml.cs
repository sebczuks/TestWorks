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


namespace Produkt_Katalog_Final_V
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShowDB show = new ShowDB();
        DBControll DbControll = new DBControll();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = TB_Login.Text;
            string password = PB_Password.Password;
            DbControll.CheckLoginOK(login, password);
           
        }
        public MainWindow()
        {
            InitializeComponent();
          DG_Produkte.ItemsSource = show.ShowProdukteTable(DbControll.loginOk);
        }

      
    }
}
