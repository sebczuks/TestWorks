using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LargeFamilyCalender.Models;
using LargeFamilyCalender.Services;
using LargeFamilyCalender.Services.UserServices;

namespace LargeFamilyCalender.Views.UserViews
{
    public partial class AddUserView : Form
    {
        public AddUserView()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(149, 162, 144);
        }
        public Color Color;
        public User user = new User();
        public UserService uService = new UserService();
        public UserService UserService = new UserService();
       
         
        

        private void AddUserView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LB_SchholOrWork.Text = "Praca";
           // public bool _isAdoult = true; 


        }

        private void BTN_AddNewUser_Click(object sender, EventArgs e)
        {

            uService.AddUser(user);
        }
    }
}
