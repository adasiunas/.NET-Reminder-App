using Quartz;
using System;

namespace Reminder_desktop_application
{
    public class Task
    {
        public string ReminderText { get; set; }
        public TimeSpan StartingTime { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime NotificationTime { get; set; }
        public bool isDailyNotifed { get; private set; }
        public JobKey JobKey { get; set; }

        public delegate void NotificationEventHandler(object sender, EventArgs e);

        public event NotificationEventHandler TaskStarted;

        public Task(string reminder, DateTime startingDate, TimeSpan startingTime, bool dailyflag)
        {
            ReminderText = reminder;
            StartingDate = new DateTime(startingDate.Year, startingDate.Month, startingDate.Day);
            StartingTime = new TimeSpan(startingTime.Hours, startingTime.Minutes, 0);
            NotificationTime = StartingDate + StartingTime;
            JobKey = new JobKey(NotificationTime.ToShortDateString());
            isDailyNotifed = dailyflag;
        }

        public void OnNotificationStarted(object sender, EventArgs e)
        {
            if (TaskStarted != null)
                TaskStarted(sender, e);
        }
    }
}
