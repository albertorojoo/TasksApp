using Microsoft.Extensions.DependencyInjection;

namespace Features.CreateTask;

public static class CreateTask
{
    public static void RegisterCreateTaskServices(this IServiceCollection services)
    {
        services.AddScoped<CreateTaskProcessor>();
    }
}
