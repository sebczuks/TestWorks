using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendarz
{
    public partial class KalendarzWindow : Form
    {
        public KalendarzWindow()
        {
            InitializeComponent();
        }

        private void BTN_DisplayTasksWindow_Click(object sender, EventArgs e)
        {
            TasksUI tasksUI = new TasksUI();
            tasksUI.Show();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            KimJestesWindowcs kimJestesWindowcs = new KimJestesWindowcs();
            kimJestesWindowcs.Show();
        }

        private void KalendarzWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
