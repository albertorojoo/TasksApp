using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Features.CreateTask;

public static class CreateTaskEndpoint
{
    public static void MapCreateTask(this WebApplication app)
    {
        app.MapPost("/tasks", async (
            CreateTaskRequest request,
            CreateTaskProcessor processor,
            CancellationToken ct) =>
        {
            await processor.ProcessAsync(request);
            return Results.Ok();
        });
    }
}
