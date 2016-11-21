using Quartz;
using Quartz.Impl;
using System;

namespace Reminder_desktop_application
{
    public class NotificationControler : IControler<Task>
    {
        ISchedulerFactory schedulerFactor = new StdSchedulerFactory();
        IScheduler scheduler;

        public NotificationControler()
        {
            scheduler = schedulerFactor.GetScheduler();
            scheduler.Start();
        }

        public void Add(Task task)
        {
            if (task.NotificationTime >= DateTime.Now)
            {
                if (task.isDailyNotifed)
                {
                    IJobDetail taskToNotify = JobBuilder.Create<Notification>().WithIdentity(task.NotificationTime.ToString()).Build();
                    taskToNotify.JobDataMap["Task"] = task;
                    ITrigger trigger = TriggerBuilder.Create()
                        .WithDailyTimeIntervalSchedule
                        (s => 
                            s.WithIntervalInHours(24)
                            .OnEveryDay()
                            .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(task.StartingTime.Hours, task.StartingTime.Minutes)))
                            .Build();
                    scheduler.ScheduleJob(taskToNotify, trigger);
                }
                else
                {
                    IJobDetail taskToNotify = JobBuilder.Create<Notification>().WithIdentity(task.NotificationTime.ToString()).Build();
                    taskToNotify.JobDataMap["Task"] = task;
                    ITrigger trigger = TriggerBuilder.Create().StartAt(task.NotificationTime).Build();
                    scheduler.ScheduleJob(taskToNotify, trigger);
                }
            }
        }

        public void Remove(Task task)
        {
            scheduler.DeleteJob(task.JobKey);
        }

        public void Stop()
        {
            scheduler.Shutdown();
        }
    }
}
