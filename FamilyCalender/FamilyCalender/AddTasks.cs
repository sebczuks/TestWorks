using FamilyCalender.DbModels;
using FamilyCalender.Service;
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

namespace FamilyCalender
{
    public partial class AddTasksWindow : Form
    {
        internal string form1valueName;
        internal int TaskID;
        internal int form1valueUserID;

        public AddTasksWindow()
        {
            InitializeComponent();

            List<Tasks> tasksList = DisplayTasks.DisplayTasksList();
            List<Users> Emilia = DisplayUsers.GetUserData(1);

            

            foreach (Tasks t in tasksList)

            {
                CBOX_TaskName.Items.Add(t.Name);
                
            }
           

        }

        private void BTN_ADDTask_Click(object sender, EventArgs e)
        {
            // call out the function that will insert data to TasksLog DB 
            // TaskID, AsseigneID, DateTimex2, CateoryID
           // var costam = TaskID;
            TaskService taskService = new TaskService();

            taskService.AddNewTask(TaskID, form1valueUserID, DateTime.Now);
            taskService.AddNewTask(1, 4, DateTime.Now);

        }

        private void BTN_ADDNote_Click(object sender, EventArgs e)
        {

        }

        private void CBOX_TaskName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTasksWindow_Load(object sender, EventArgs e)
        {
            
           label7.Text = form1valueName;
           label8.Text = form1valueName;
        }
    }
}
