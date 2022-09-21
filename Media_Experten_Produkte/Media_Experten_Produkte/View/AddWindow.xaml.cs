using Media_Experten_Produkte.Model;
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
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        ChangeDB adder = new ChangeDB();
        public AddWindow()
        {
            InitializeComponent();
        }

        private void BTN_AddValues_Click(object sender, RoutedEventArgs e)
        {
            string name = TBox_AddName.Text;
            int ID = int.Parse(TBox_AddID.Text);
            string producer = TBox_AddProducer.Text;
            int preis = int.Parse(TBox_AddPreiss.Text);
            int bestand = int.Parse(TBox_AddBestand.Text);
            string typ = TBox_AddTyp.Text;
            adder.Addvalues(ID, name, producer, preis, bestand, typ);

        }
    }
}
