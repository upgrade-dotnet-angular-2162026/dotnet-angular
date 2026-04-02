namespace HandsOnAPIUsingDI.Services
{
    public class MessageService : IMessageService
    {
        public List<string> flowers = new List<string>()
        {
            "Rose","Lilly"
        };

        public List<string> Flowers => flowers;

        public string GetMessage()
        {
            return "Hello from MessageService";
        }
        public void Send(string flower)
        {
            flowers.Add(flower);
        }
       
    }
}
