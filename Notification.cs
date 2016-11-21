using Quartz;
using System;

namespace Reminder_desktop_application
{
    public class Notification : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            JobDataMap data = context.JobDetail.JobDataMap;
            Task task = (Task)data["Task"];
            task.OnNotificationStarted(task, EventArgs.Empty);
        }
    }
}
