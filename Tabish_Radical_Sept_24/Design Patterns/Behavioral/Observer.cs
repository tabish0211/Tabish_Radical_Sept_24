using System;
using System.Collections.Generic;

namespace Tabish_Radical_Sept_24.Design_Patterns.Behavioral
{
    public interface INotifier
    {
        void Notify(string message);
    }

    public class SmsNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

    public class WhatsAppNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"WhatsApp Notification: {message}");
        }
    }

    public class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

    public class Notifier
    {
        private readonly List<INotifier> _notifiers = new List<INotifier>();

        public void AddNotifier(INotifier notifier)
        {
            _notifiers.Add(notifier);
        }

        public void RemoveNotifier(INotifier notifier)
        {
            _notifiers.Remove(notifier);
        }

        public void NotifyAll(string message)
        {
            foreach (var notifier in _notifiers)
            {
                notifier.Notify(message);
            }
        }
    }

    public class   client
    {
        public static void Main()
        {
            var notifier = new Notifier();
            notifier.AddNotifier(new SmsNotifier());
            notifier.AddNotifier(new WhatsAppNotifier());
            notifier.AddNotifier(new EmailNotifier());

            notifier.NotifyAll("Hello World");
        }

    }
}
