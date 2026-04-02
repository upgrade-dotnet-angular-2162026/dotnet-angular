namespace HandsOnDIUsingConsole
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class SmsService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

    public class Notification
    {
        private readonly IMessageService _messageService;

       
        // Dependency Injection (constructor injection)
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Send(string message)
        {
            _messageService.SendMessage(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // You decide which service to inject
            IMessageService service = new EmailService();
            // Or: IMessageService service = new SmsService();

            Notification notification = new Notification(service);//email server
            notification.Send("Hello DI World!");
            service= new SmsService();
            notification=new Notification(service); //sms service
            notification.Send("Hello DI World!!");
        }
    }
}
