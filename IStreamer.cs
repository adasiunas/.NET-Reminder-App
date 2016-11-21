using System.Collections;
using System.Collections.Generic;

namespace Reminder_desktop_application
{
    public interface IStreamer<TKey, TValue>
    {
        void SaveData<T>(T dataToSave) where T : IDictionary<TKey, TValue>, ICollection;
        void SaveData(TValue dataToSave);
        TKey[] GetData();
    }
}
