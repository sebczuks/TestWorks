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

        


        

      
       // static readonly string[] listaPrzedmiotow = { "Mathe", "Deutsch", "Englisch", "IT", "Sport", "note Bio", "note Kunst", "note Religion", "note Werken", "note TG", "note Geo", "note Fizyka", "note Musik", "note Francuski", "note cos tam" };

      

        private void nextPrzedmiotSzkolny_Click(object sender, RoutedEventArgs e)
        {

            float notenZahl = float.Parse(textBoxiloscPrzedmiotow.Text);
            float durchschnitt = 0.00f;

            int noteMathe = Convert.ToInt32(textBoxMathenote.Text);
            int noteDeutsch = Convert.ToInt32(textBoxDeutschnote.Text);
            int noteEnglish = Convert.ToInt32(textBoxEnglischnote.Text);
            int noteIT = Convert.ToInt32(textBoxITnote.Text);
            int noteSport = Convert.ToInt32(textBoxSportnote.Text);
            int noteMusik = Convert.ToInt32(textBoxMusikTnote.Text);
            int noteGeo = Convert.ToInt32(textBoxGeonote.Text);
            int noteBio = Convert.ToInt32(textBoxBionote.Text);
            int noteKunst = Convert.ToInt32(textBoxKunstnote.Text);
            int noteWerken = Convert.ToInt32(textBoxWerkennote.Text);
            int noteTG = Convert.ToInt32(textBoxTGnote.Text);
            int noteReligion = Convert.ToInt32(textBoxReligionnote.Text);
            int noteFranzösisch = Convert.ToInt32(textBoxFrannote.Text);
            int noteChemie = Convert.ToInt32(textBoxChemienote.Text);
            int noteGesichte = Convert.ToInt32(textBoxGeschichtenote.Text);
            int noteWirtschaft = Convert.ToInt32(textBoxWirtschaftnote.Text);
            int notePhysik=Convert.ToInt32(textBoxPhysiknote.Text);
            int notewg = Convert.ToInt32(textBoxWGnote.Text);
            int noteGPG = Convert.ToInt32(textBoxGPGnote.Text);
            int noteHSU = Convert.ToInt32(textBoxHSUNaturnote.Text);
            int noteWuB = Convert.ToInt32(textBoxWuBnote.Text);




            //this method will change the label PrzedmiotSzkolny to new and will be adding the Notes 
            // listaPrzedmiotow = {"Mathe", "Deutsch", "Englisch", "IT", "Sport", "note Bio", "note Kunst", "note Religion", "note Werken", "note TG", "note Geo", "note Fizyka", "note Musik", "note Francuski", "note cos tam" };
            durchschnitt = (noteWuB + noteMathe + noteDeutsch + noteSport + noteEnglish + noteIT + noteMusik + noteGeo + noteGeo + notewg + noteGPG + noteBio + noteHSU +noteKunst + noteWerken + noteTG + noteReligion + noteFranzösisch +noteChemie + noteGesichte + noteWirtschaft + notePhysik ) / notenZahl;

            string s = durchschnitt.ToString("N2");

            Wynik.Text = s;
               
           // PrzedmiotSzkolny.Text = listaPrzedmiotow[i];
        }
    }
}
