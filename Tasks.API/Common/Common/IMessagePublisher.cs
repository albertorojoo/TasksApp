namespace Common;

public interface IMessagePublisher
{
    Task PublishMessage(Guid taskId);
}
