using Common;
using ConsoleBus;
using Features.CreateTask;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.RegisterCreateTaskServices();
builder.Services.AddScoped<IMessagePublisher, ConsoleBusPublisher>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapCreateTask();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
