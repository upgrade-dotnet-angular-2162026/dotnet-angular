namespace HandsOnAPIUsingDI.Services
{
    public interface IMessageService
    {
        List<string> Flowers { get; }
        string GetMessage();
        void Send(string flower);
    }
}
