using Common;

namespace Features.CreateTask;

public class CreateTaskProcessor
{
    private readonly IMessagePublisher _messagePublisher;

    public CreateTaskProcessor(IMessagePublisher messagePublisher)
    {
        _messagePublisher = messagePublisher;
    }

    public async Task<CreateTaskResponse> ProcessAsync(CreateTaskRequest request)
    {
        var taskId = Guid.NewGuid();

        await _messagePublisher.PublishMessage(taskId);

        return new CreateTaskResponse(taskId);
    }
}
