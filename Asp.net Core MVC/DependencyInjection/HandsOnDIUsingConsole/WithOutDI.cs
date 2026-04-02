using System;

namespace WithoutDI
{
    public class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class Notification
    {
        private EmailService _emailService;

        public Notification()
        {
            // Tight coupling: Notification depends directly on EmailService
            _emailService = new EmailService();
        }

        public void Send(string message)
        {
            _emailService.SendEmail(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notification notify = new Notification();
            notify.Send("Hello World!");
        }
    }
}
//Problem: If tomorrow you want to send SMS instead of Email,
//you must change the Notification class.