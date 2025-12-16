using Common;

namespace ConsoleBus;

public class ConsoleBusPublisher : IMessagePublisher
{
    public Task PublishMessage(Guid message)
    {
        Console.WriteLine(message!.ToString());
        return Task.CompletedTask;
    }
}
