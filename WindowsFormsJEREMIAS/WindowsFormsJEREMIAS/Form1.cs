using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace WindowsFormsJEREMIAS
{
    public partial class Form1 : Form
    {

        static SqlConnection _connenction; // statisches Objekt vom Typ MySqlConnection initialisieren -> Bezeichner: _connection
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_connecttoDB_Click(object sender, EventArgs e)
        {
            DB_Controll database = new DB_Controll(); // neues Objekt vom Typ Db initialisieren -> Bezeichner: database
                                                      // _conenction = 
            _connenction = database.Connect(); // Baue Verbindung zu datenbank auf UND speicher die Verbindung in _connection


        }

    
    }
}
