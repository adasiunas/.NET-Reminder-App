
namespace Reminder_desktop_application
{
    public interface IControler<T>
    {
        void Add(T element);
        void Remove(T element);
        void Stop();
    }
}
