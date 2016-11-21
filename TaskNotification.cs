using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public partial class TaskNotification : MetroFramework.Forms.MetroForm
    {
        public Task taskToNotify;
        public TaskControler taskControler;

        public TaskNotification(Task tasktonotify, TaskControler taskControler)
        {
            InitializeComponent();
            taskToNotify = tasktonotify;
            this.taskControler = taskControler;
            LoadTask();
        }

        public void LoadTask()
        {
            notificationBox.Text = taskToNotify.ReminderText;
        }

        private void doneLink_Click(object sender, EventArgs e)
        {
            if (laterCheckBox.Checked == true)
            {
                taskControler.Remove(taskToNotify);
                taskControler.Add(
                    new Task(notificationBox.Text, DateTime.Now, DateTime.Now.TimeOfDay + TimeSpan.Parse("0:" + minutesComboBox.Text), taskToNotify.isDailyNotifed));
            }
            else
            {
                taskControler.Remove(taskToNotify);
            }
            this.Close();
        }

        private void laterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (laterCheckBox.Checked == true)
            {
                laterGroupBox.Enabled = true;
                minutesComboBox.SelectedIndex = 0;
            }
            else
            {
                laterGroupBox.Enabled = false;
            }
        }
    }
}
