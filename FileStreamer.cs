using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Reminder_desktop_application
{
    public class FileStreamer : IStreamer<string, List<Task>>
    {
        private string FILE_NAME = System.Configuration.ConfigurationManager.AppSettings["filePath"];
        public string[] data;

        public void SaveData<T>(T dataToSave) where T : IDictionary<string, List<Task>>, ICollection
        {
            using (StreamWriter fileStream = new StreamWriter(FILE_NAME))
            {
                foreach (string key in dataToSave.Keys)
                {
                    foreach (Task task in dataToSave[key])
                    {
                        fileStream.Write(task.StartingDate.ToString() + ",");
                        fileStream.Write(task.StartingTime.ToString() + ",");
                        fileStream.Write(task.ReminderText + ",");
                        fileStream.WriteLine(task.isDailyNotifed.ToString());
                    }
                }
            }
        }

        public void SaveData(List<Task> dataToSave)
        {
            using (StreamWriter fileStream = new StreamWriter(FILE_NAME, true))
            {
                foreach (Task task in dataToSave)
                {
                    fileStream.Write(task.StartingDate.ToString() + ",");
                    fileStream.Write(task.StartingTime.ToString() + ",");
                    fileStream.Write(task.ReminderText + ",");
                    fileStream.WriteLine(task.isDailyNotifed.ToString());
                }
            }
        }

        public string[] GetData()
        {
            try
            {
                data = System.IO.File.ReadAllLines(FILE_NAME);
                return data;
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException(e.ToString());
            }
        }
    }
}
