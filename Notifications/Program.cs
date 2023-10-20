using Dragonfly.Application.Services;
using Dragonfly.CQRS.Commands;
using Dragonfly.CQRS.Queries;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddCommands();
builder.Services.AddQueries();
builder.Services.AddApplicationServices();

//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();