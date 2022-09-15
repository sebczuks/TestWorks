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
using System.Data;

namespace Media_Experten_Produkte
{
    /// <summary>
    /// Interaction logic for ChangeWindow.xaml
    /// </summary>
    public partial class ChangeWindow : Window
    {
        Produkte produkte = new Produkte();


        public ChangeWindow()
        {
            InitializeComponent();

            
            DataGrid_allProducts.ItemsSource =  produkte.ShowProdukteTable();

        }

        private void BTN_changeAll_Click(object sender, RoutedEventArgs e)
        {
            // connect to DB
            // "UPDATE Produkte SET ProduktName = 'TBox_changeName.Text;' WHERE ID = TBox_ID.Text
        }
    }
}
