using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public partial class Reminder : MetroFramework.Forms.MetroForm
    {
        /*  TODO:
         *  Lazy
         */

        public TaskControler taskControler = new TaskControler(new FileStreamer(), new NotificationControler());
        public List<Task> allDayTaks;
        public Dictionary<string, List<Task>> tasksForEeachDay;
        public Task taskToNotify;

        public Reminder()
        {
            InitializeComponent();
            taskControler.TaskAppeared += SubscribeForNotification;
            taskControler.LoadTasks();
            PrintDayTasks(DateTime.Now.ToShortDateString());
        }

        private void addLink_Click(object sender, EventArgs e)
        {
            Form NewTaskForm = new NewTaskForm(taskControler, reminderDateTime.Value);
            NewTaskForm.ShowDialog();
            reminderTabControl.SelectedTab = homeTab;
            PrintDayTasks(reminderDateTime.Value.ToShortDateString());
        }

        private void Reminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            taskControler.Stop();
            this.notificationIcon.Dispose();
            Application.Exit();
        }

        private void deleteLink_Click(object sender, EventArgs e)
        {
            if (reminderTasksView.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Task temp = (Task)reminderTasksView.SelectedItems[0].Tag;
                        taskControler.Remove(temp);
                        PrintDayTasks(temp.StartingDate.ToShortDateString());
                    }
                    catch(RemoveTaskException exp)
                    {
                        MessageBox.Show(exp.ToString());
                    }
                }
            }
        }

        private void doneLink_Click(object sender, EventArgs e)
        {
            deleteLink_Click(sender, e);
        }
        private void Reminder_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShootOutNotification(object sender, EventArgs e)
        {
            taskToNotify = (Task)sender;
            notificationIcon.BalloonTipTitle = this.Text;
            notificationIcon.BalloonTipText = taskToNotify.ReminderText;
            notificationIcon.ShowBalloonTip(5000);
        }
        private void notificationIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notificationIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            TaskNotification notificationForm = new TaskNotification(taskToNotify, taskControler);
            notificationForm.FormClosing += notificationForm_FormClosing;
            notificationForm.Show();
            notificationForm.WindowState = FormWindowState.Normal;
        }

        private void SubscribeForNotification(Task task)
        {
            task.TaskStarted += ShootOutNotification;
        }

        private void PrintDayTasks(string date)
        {
            reminderTasksView.Items.Clear();
            if (taskControler.DailyTasks.Count != 0)
            {
                foreach (Task task in taskControler.DailyTasks)
                {
                    PrintingTheTask(task);
                }
            }
            if (taskControler.AllDays.Contains(date))
            {
                allDayTaks = taskControler.AllTasks[date];
                foreach (Task task in allDayTaks)
                {
                    PrintingTheTask(task);
                }
            }
        }

        private void PrintingTheTask(Task task)
        {
            ListViewItem taskForList = new ListViewItem();
            taskForList.Text = task.StartingTime.ToString(@"hh\:mm");
            taskForList.SubItems.Add(task.ReminderText);
            taskForList.Tag = task;
            reminderTasksView.Items.Add(taskForList);
        }

        private void reminderDateTime_ValueChanged(object sender, EventArgs e)
        {
            PrintDayTasks(reminderDateTime.Value.ToShortDateString());
        }

        private void reminderTasksView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (reminderTasksView.SelectedItems.Count == 1)
            {
                reminderTabControl.SelectedTab = taskDetailsTab;
                Task temp = (Task)reminderTasksView.SelectedItems[0].Tag;
                taskDetailsTab.Tag = temp;
                taskDetailsTab.Text = detailsLabel.Text;
                detailsBox.Text = temp.ReminderText;
                timeLabel.Text = temp.StartingDate.ToShortDateString() + " " + reminderTasksView.SelectedItems[0].Text;
            }
        }

        private void notificationForm_FormClosing(object sender, EventArgs e)
        {
            PrintDayTasks(DateTime.Now.ToShortDateString());
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form NewTaskForm = new NewTaskForm(taskControler, reminderDateTime.Value, detailsBox.Text);
            NewTaskForm.ShowDialog();
            taskControler.Remove((Task)taskDetailsTab.Tag);
            reminderTabControl.SelectedTab = homeTab;
            PrintDayTasks(reminderDateTime.Value.ToShortDateString());
        }

        private void reminderDateTime_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("%{DOWN}");
        }
    }
}
