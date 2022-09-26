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
using Microsoft.Data.SqlClient;
using Media_Experten_Produkte.Model;
using Media_Experten_Produkte.ViewModel;

namespace Media_Experten_Produkte
{
    /// <summary>
    /// Interaction logic for ChangeWindow.xaml
    /// </summary>
    public partial class ChangeWindow : Window
    {
        ChangeDB  change = new ChangeDB();
        Produkte produkte = new Produkte();
        GUIBehavior get = new GUIBehavior();


        public ChangeWindow()
        {
            InitializeComponent();


            DataGrid_allProducts.ItemsSource = produkte.ShowProdukteTableafterLogin();

        }

     

 

        private void BTN_changeAllvalues_Click(object sender, RoutedEventArgs e)
        {
            string name = TBox_changeName.Text;
            int mne = int.Parse(TBox_changeID.Text);
            string producer = TBox_changeProducer.Text;
            int preis = int.Parse(TBox_changePreis.Text);
            int bestand = int.Parse(TBox_changeBestand.Text);
            string typ = TBox_changeTyp.Text;


            change.Change(mne, name, producer, preis, bestand, typ);
            DataGrid_allProducts.ItemsSource = produkte.ShowProdukteTableafterLogin();
        }

        private void TBox_changeID_TextChanged(object sender, TextChangedEventArgs e)
        {

            //   TO DO 
            //-Check if not int 
           
            int id = int.Parse(TBox_changeID.Text);

            TBox_changeName.Text = get.GetValue(id, "ProduktName");
            TBox_changeProducer.Text = get.GetValue(id, "ProduktProducer");
            TBox_changeTyp.Text = Convert.ToString(get.GetIntValue(id, "ProduktType"));


            TBox_changePreis.Text =   get.GetValue(id, "ProduktPreiss");
            //TBox_changeBestand.Text = Convert.ToString(get.GetIntValue(id, "ProduktBestend"));

          

         
        }
    }
}
