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

namespace NotenDurchschnitt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

        }
        string[] listaPrzedmiotow = { "Mathe", "Deutsch", "Englisch", "IT", "Sport", "note Bio", "note Kunst", "note Religion", "note Werken", "note TG", "note Geo", "note Fizyka", "note Musik", "note Francuski", "note cos tam" };

        private void ButtonRechneDR_Click(object sender, RoutedEventArgs e)
        {
            int noteMathe = 2;
            int noteDeutsch = 2;
            int noteEnglish = 1;
            int noteIT = 3;
            int noteSport = 1;
            int noteMusik = 1;
            int noteGeo = 1;
            int noteBio = 3;
            int noteKunst = 2;
            int noteWerken = 1;
            int noteTG = 2;
            int noteReligion = 1;

           // float durchschnitt;

            float notenZahl = 12.00f;


            float durchschnitt = 0.00f;





           durchschnitt = (noteMathe + noteDeutsch + noteEnglish + noteIT + noteBio + noteKunst + noteMusik + noteReligion + noteWerken + noteTG + noteSport +noteGeo ) / notenZahl;
            string s = durchschnitt.ToString("N4");


            TextBlockDurschschitt.Text =  s;
            //Wynik.Text = s;
            //Convert.ToString(durchschnitt);   nie dziala 
        }

        private void nextPrzedmiotSzkolny_Click(object sender, RoutedEventArgs e)
        {
            string[] listaPrzedmiotow = {"Mathe", "Deutsch", "Englisch", "IT", "Sport", "note Bio", "note Kunst", "note Religion", "note Werken", "note TG", "note Geo", "note Fizyka", "note Musik", "note Francuski", "note cos tam" };
        
                for(int i = 0; i < listaPrzedmiotow.Length; i++)
                    {

                        PrzedmiotSzkolny.Text = listaPrzedmiotow[i];


                    }
        }
    }
}
