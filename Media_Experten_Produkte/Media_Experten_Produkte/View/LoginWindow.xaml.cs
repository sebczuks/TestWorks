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
using System.Windows.Shapes;


namespace Media_Experten_Produkte
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        //WindowsInteraction loginchecker = new WindowsInteraction();
        public LoginWindow()
        {
            InitializeComponent();
        }
        
       // MainWindow object BTN_Change { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(TB_Username.Text == TB_Password.Text)
            {
               // checkLogin.loginOK = false;
               // loginchecker.loginOK = false;

             //   BTN_Change.IsVisible;
               
                
            }
            else { MessageBox.Show("Wrong LOGIN or PASSWORD"); }
        }
    }
}
