using FamilyCalender.DbModels;
using FamilyCalender.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using FamilyCalender.Service;

namespace FamilyCalender
{
    public partial class MainCalender : Form
    {
        public void ResetFields1()
        {
            PanelUser1Week.BackColor = Color.Transparent;
            PanelUser2Week.BackColor = Color.Transparent;
            PanelUser3Week.BackColor = Color.Transparent;
            PanelUser4Week.BackColor = Color.Transparent;
            PanelUser5Week.BackColor = Color.Transparent;
            PanelUser6Week.BackColor = Color.Transparent;

        }

        public void HideRightPanelLabels()
        {
            PN_RP_Left.Visible = false;
            PN_RP_Left_UserData.Visible = false;
           // panel_Terminy.Visible = false;

        }
        public void ShowRightPanelLabels()
        {
            PN_RP_Left.Visible = true;
            PN_RP_Left_UserData.Visible = true;
            ZADANIA.Visible = true;
            OCENY.Visible = true;
            panel_Terminy.Visible = true;
            label8.Visible = true;

        }
        public void HighlightRightPanel()
        {
            P_Zadania.BackColor = Color.FromArgb(79, 61, 120);
            P_Oceny.BackColor = Color.FromArgb(79, 61, 120);
            panel_Terminy.BackColor = Color.FromArgb(79, 61, 120);
        }


        public DisplayUsers Emilia = new DisplayUsers();

        public MainCalender()
        {

            InitializeComponent();
            //  _displayUsers = new DisplayUsers();

            IEnumerable<Users> IEEmilia = DisplayUsers.GetUserData(1);

            //IEnumerable<Users> Nokodem = DisplayUsers.GetUserData(3);

            // string Imie1 = Emilia.Name;
            //BTN_User1.Text = "Emilia";
        }

        private void MainCalender_Load(object sender, EventArgs e)
        {
            HideRightPanelLabels();
            DateMainWindow.Text = DateTime.Now.DayOfWeek.ToString();
            DateMainWindow.Text = DateTime.Now.Day.ToString();

            //panelRight.BackColor = Color.FromArgb(105, 92, 147);
            // panel_Terminy.BackColor = Color.FromArgb(105, 92, 147);
            LB_DateMW.Text = DateTime.Now.Year.ToString();
            LB_MonthDayMW.Text = DateTime.Now.ToString("MMM");

            List<Users> UserList = DisplayUsers.UsersNames();
            List<Users> Emilia = DisplayUsers.GetUserData(1);


            BTN_User1.Text = "Emilia";
            BTN_User2.Text = "Paulina";
            BTN_User3.Text = "Nikodem";
            BTN_User4.Text = "Halina";
            BTN_User5.Text = "Alex";
            BTN_User6.Text = "Sebastian";

        }





        private void BTN_User1_Click(object sender, EventArgs e)
        {
            List<Users> Emilia = DisplayUsers.GetUserData(1);
            HighlightRightPanel();
            ShowRightPanelLabels();
            foreach (Users u in Emilia)
            {
                LB_PN_RP_UserData_Name.Text = u.Name;
                LB_PN_RP_UserData_Age.Text = u.DateOfBirth.ToString();
                LB_PN_RP_UserData_Class.Text = u.Class.ToString() + " klasy";
                LB_PN_RP_UserData_Weihgt.Text = u.Weight.ToString();
                LB_PN_RP_UserData_Height.Text = u.Hight.ToString() + " cm";

            };

            ResetFields1();
            PanelUser1Week.BackColor = Color.FromArgb(79, 61, 120);



        }

        private void BTN_User2_Click(object sender, EventArgs e)
        {


            List<Users> Paulina = DisplayUsers.GetUserData(2);
            P_Zadania.BackColor = Color.FromArgb(79, 61, 120);
            P_Oceny.BackColor = Color.FromArgb(79, 61, 120);
            ShowRightPanelLabels();

            foreach (Users u in Paulina)
            {
                LB_PN_RP_UserData_Name.Text = u.Name;
                LB_PN_RP_UserData_Age.Text = u.DateOfBirth.ToString();
                LB_PN_RP_UserData_Class.Text = u.Class.ToString() + " klasy";
                LB_PN_RP_UserData_Weihgt.Text = u.Weight.ToString();
                LB_PN_RP_UserData_Height.Text = u.Hight.ToString() + " cm";
            };

            ResetFields1();
            PanelUser2Week.BackColor = Color.FromArgb(79, 61, 120);

        }

        private void BTN_User5_Click(object sender, EventArgs e)
        {




            List<Users> Alex = DisplayUsers.GetUserData(4);
            P_Zadania.BackColor = Color.FromArgb(79, 61, 120);
            P_Oceny.BackColor = Color.FromArgb(79, 61, 120);
            ShowRightPanelLabels();

            foreach (Users u in Alex)
            {
                LB_PN_RP_UserData_Name.Text = u.Name;
                LB_PN_RP_UserData_Age.Text = u.DateOfBirth.ToString();
                LB_PN_RP_UserData_Class.Text = u.Class.ToString() + " klasy";
                LB_PN_RP_UserData_Weihgt.Text = u.Weight.ToString();
                LB_PN_RP_UserData_Height.Text = u.Hight.ToString() + " cm";
            };

            ResetFields1();
            PanelUser5Week.BackColor = Color.FromArgb(79, 61, 120);


        }

        private void BTN_User3_Click(object sender, EventArgs e)
        {

            List<Users> Nikodem = DisplayUsers.GetUserData(3);
            P_Zadania.BackColor = Color.FromArgb(79, 61, 120);
            P_Oceny.BackColor = Color.FromArgb(79, 61, 120);
            ShowRightPanelLabels();

            foreach (Users u in Nikodem)
            {
                LB_PN_RP_UserData_Name.Text = u.Name;
                LB_PN_RP_UserData_Age.Text = u.DateOfBirth.ToString();
                LB_PN_RP_UserData_Class.Text = u.Class.ToString() + " klasy";
                LB_PN_RP_UserData_Weihgt.Text = u.Weight.ToString();
                LB_PN_RP_UserData_Height.Text = u.Hight.ToString() + " cm";
            };
            ResetFields1();
            PanelUser3Week.BackColor = Color.FromArgb(79, 61, 120);


        }

        private void BTN_User4_Click(object sender, EventArgs e)
        {
            List<Users> Halina = DisplayUsers.GetUserData(5);
            P_Zadania.BackColor = Color.FromArgb(79, 61, 120);
            P_Oceny.BackColor = Color.FromArgb(79, 61, 99);
            ShowRightPanelLabels();



            foreach (Users u in Halina)
            {

                LB_PN_RP_UserData_Name.Text = u.Name;
                LB_PN_RP_UserData_Age.Text = u.DateOfBirth.ToString();
                LB_PN_RP_UserData_Class.Text = u.Class.ToString() + " klasy";
                LB_PN_RP_UserData_Weihgt.Text = u.Weight.ToString();
                LB_PN_RP_UserData_Height.Text = u.Hight.ToString() + " cm";
            };

            ResetFields1();
            PanelUser4Week.BackColor = Color.FromArgb(79, 61, 120);

        }

        private void BTN_User6_Click(object sender, EventArgs e)
        {

            List<Users> Kaziu = DisplayUsers.GetUserData(6);
            P_Zadania.BackColor = Color.FromArgb(79, 61, 120);
            P_Oceny.BackColor = Color.FromArgb(79, 61, 99);
            ShowRightPanelLabels();

            foreach (Users u in Kaziu)
            {

                LB_PN_RP_UserData_Name.Text = u.Name;
                LB_PN_RP_UserData_Age.Text = u.DateOfBirth.ToString();
                LB_PN_RP_UserData_Class.Text = u.Class.ToString() + " klasy";
                LB_PN_RP_UserData_Weihgt.Text = u.Weight.ToString();
                LB_PN_RP_UserData_Height.Text = u.Hight.ToString() + " cm";
            };
            ResetFields1();
            PanelUser6Week.BackColor = Color.FromArgb(79, 61, 120);



        }

        private void LB_Monday_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTasksWindow addTasksWindow = new AddTasksWindow();
            addTasksWindow.ShowDialog();

        }

        private void Premonth_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void BTN_U1Thr_Click(object sender, EventArgs e)
        {
            AddTasksWindow addTasksWindow = new AddTasksWindow();
            addTasksWindow.form1valueName = "Emilia";
            addTasksWindow.form1valueUserID = 1;
            addTasksWindow.TaskID = 1; //get name from CBox and change to int
            addTasksWindow.ShowDialog();
           
            //var user = "Emilia";

        }

        private void BTN_U2Thr_Click(object sender, EventArgs e)
        {
            //Date 
            AddTasksWindow addTasksWindow = new AddTasksWindow();
            addTasksWindow.form1valueName = "Paulina";
            addTasksWindow.form1valueUserID = 2;
            addTasksWindow.ShowDialog();

        }

        private void BTN_U1Sat_Click(object sender, EventArgs e)
        {
            AddTasksWindow addTasksWindow = new AddTasksWindow();
            addTasksWindow.form1valueName = Emilia.GetHashCode().ToString();

            addTasksWindow.form1valueUserID = 1;
           // addTasksWindow.TaskID = 1; //get name from CBox and change to int
            addTasksWindow.ShowDialog();

        }

        private void BTN_U2Sat_Click(object sender, EventArgs e)
        {
            AddTasksWindow addTasksWindow = new AddTasksWindow();
            addTasksWindow.form1valueName = "Paulina";
            addTasksWindow.form1valueUserID = 2;
            addTasksWindow.ShowDialog();

        }

        private void BTN_U3Sat_Click(object sender, EventArgs e)
        {
            AddTasksWindow addTasksWindow = new AddTasksWindow();
            addTasksWindow.form1valueName = "Nikodem";
            addTasksWindow.form1valueUserID = 3;
            addTasksWindow.ShowDialog();

        }

        private void BTN_U5Sat_Click(object sender, EventArgs e)
        {
            AddTasksWindow addTasksWindow = new AddTasksWindow();
            addTasksWindow.form1valueName = "Alex";
            addTasksWindow.form1valueUserID = 4;
            addTasksWindow.ShowDialog();
        }

        private void BTN_U6Sat_Click(object sender, EventArgs e)
        {
            AddTasksWindow addTasksWindow = new AddTasksWindow();
            addTasksWindow.form1valueName = "Sebastian";
            addTasksWindow.form1valueUserID = 1;
            addTasksWindow.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

