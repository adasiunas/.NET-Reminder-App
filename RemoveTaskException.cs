using System;

namespace Reminder_desktop_application
{
    class RemoveTaskException : Exception
    {
        public RemoveTaskException() : base() { }

        public RemoveTaskException(string message) : base(message){}

        public RemoveTaskException(string message, Exception exp) : base(message, exp) { }
    }
}
