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
    public partial class NewTaskForm : MetroFramework.Forms.MetroForm
    {
        TaskControler taskControler;
        DateTime taskDate;
        public NewTaskForm(TaskControler controler)
        {
            InitializeComponent();
            taskControler = controler;
        }

        public NewTaskForm(TaskControler controler, DateTime date) : this(controler)
        {
            taskDate = date;
        }

        public NewTaskForm(TaskControler controler, DateTime date, string text) : this (controler, date)
        {
            reminderBox.Text = text;
        }

        private void saveLink_Click(object sender, EventArgs e)
        {
            Task task = new Task(reminderBox.Text, taskDate, startingTimePicker.Value.TimeOfDay, dailyCheckBox.Checked);
            taskControler.Add(task);
            this.Close();
        }

        private void cancelLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
