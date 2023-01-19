using LargeFamilyCalender.Views.UserViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LargeFamilyCalender
{
    public partial class MainWindowView : Form
    {
        

        private string _userName;

        public string User { get { return _userName; } set { _userName = value; } }

        private string _password;

        private string _email;
        private string _phone;
        private string _fax;
        private string _country;
        private string _city;
        private string _address;
        private string _address2;
        private string _address3;
        private string _address4;
        private string _address5;
        private string _address6;
        private string _address7;
        private int _count; 
        private int _count2;
        private int _count3;
        private int _count4;
        private int _count5;
        private int _count6;
        private bool _IsDone;
        private bool _IsDone2;      
        private bool _IsDone3;
        private bool _IsDone4;
        private bool _IsDone5;
        private bool _IsDone6;

        private TimeSpan _monthDay;
        private TimeSpan _nextDay;
        private DateTime _tommorow;
        private DateTime _yesturday;
        private DateTime _today;
        private DateTime _last;
        private DateTime _last2;

        private double _seconds;

        public double Hours
        {
            get { return _seconds / 3600; }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException(nameof(value),
                          "The valid range is between 0 and 24.");

                _seconds = value * 3600;
            }
        }
   
    public DateTime Tommorow
        {
            get
            {
                return _tommorow;
            }

            set
            {
                value = _tommorow; 
            }
        }

        public DateTime Today
        {
            get => _today;
            set
            {
                _today = value;
            }
        }
        public void RefreshUsersButtons()
        {
            BTN_User1.BackColor = Color.White;
            BTN_User2.BackColor = Color.White;
            BTN_User3.BackColor = Color.White;
            BTN_User4.BackColor = Color.White;
            BTN_User5.BackColor = Color.White;
            BTN_User6.BackColor = Color.White;

        }
        
        public MainWindowView()
        {

          
            InitializeComponent();
            //sets this 
            BackColor = Color.FromArgb(149, 180, 144);
            TLP_USERSANDWEEKDAYS.BackColor = Color.FromArgb(149, 162, 144);
            BTN_AddUser.Text = "Dodaj Usera";
            BTN_UserChanges.Text = "Zmień Dane";
            BTN_ManageTasks.Text = "Zarządzaj Zadaniami";

        }

        private void MainWindowView_Load(object sender, EventArgs e)
        {
            BTN_User1.Text = "Emilia";
            BTN_User2.Text = "Paulina";
            BTN_User3.Text = "Alex";
            BTN_User4.Text = "Nikodem";
            BTN_User5.Text = "Mama";
            BTN_User6.Text = "Tata";
            BTN_MonthCalender.Text = DateTime.Today.ToString("D");


        }

        private void BTN_AddUser_Click(object sender, EventArgs e)
        {
            AddUserView addUserView = new AddUserView();
            addUserView.ShowDialog();

        }

        private void BTN_UserChanges_Click(object sender, EventArgs e)
        {

        }

        private void BTN_ManageTasks_Click(object sender, EventArgs e)
        {
            AddUserView gradesView = new AddUserView();
            gradesView.ShowDialog();
        }

        private void BTN_User1_Click(object sender, EventArgs e)
        {

            RefreshUsersButtons();
            BTN_User1.BackColor = Color.FromArgb(100, 100, 100);

        }

        private void BTN_User2_Click(object sender, EventArgs e)
        {
            RefreshUsersButtons();
            BTN_User2.BackColor = Color.FromArgb(100, 100, 100);

        }

        private void BTN_User3_Click(object sender, EventArgs e)
        {
            RefreshUsersButtons();
            BTN_User3.BackColor = Color.FromArgb(100, 100, 100);

        }

        private void BTN_User4_Click(object sender, EventArgs e)
        {
            RefreshUsersButtons();
            BTN_User4.BackColor = Color.FromArgb(100, 100, 100);

        }

        private void BTN_User5_Click(object sender, EventArgs e)
        {
            RefreshUsersButtons();
            BTN_User5.BackColor = Color.FromArgb(100, 100, 100);

        }

        private void BTN_User6_Click(object sender, EventArgs e)
        {
            RefreshUsersButtons();
            BTN_User6.BackColor = Color.FromArgb(100, 100, 100);

        }
    }
}
