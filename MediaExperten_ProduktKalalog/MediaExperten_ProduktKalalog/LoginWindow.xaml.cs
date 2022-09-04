using Microsoft.Data.SqlClient;
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

namespace MediaExperten_ProduktKalalog
{
    /// <summary>
    /// Interaktionslogik für LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BTN_LoginEXIT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BTN_Login_Click(object sender, RoutedEventArgs e)
        {
            string login = TB_Login.Text;
            string password = TB_password.Text;
            SqlConnection sqlConnection = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True");
            string loginstring = "SELECT Login FROM dbo.DB_Controll WHERE ID = 1";
            string passwordstring = "SELECT Password FROM dbo.DB_Controll WHERE ID = 1";


            DB_Controll loginControll = new DB_Controll();
            loginControll.Connect();
            
            SqlCommand getlogin = new SqlCommand(loginstring, sqlConnection );
            SqlCommand getpassword = new SqlCommand(passwordstring, sqlConnection);
            getlogin.ExecuteNonQuery();


            if (login == login) // && ()
            {
                MessageBox.Show("OK");
                return;
            }
            else 
            { MessageBox.Show("Wrong login or password"); }
        }
    }
}
