using Dragonfly.Application.Services;
using Dragonfly.Cqrs.Commands;
using Dragonfly.Cqrs.Queries;
using Dragonfly.Domain.Services;
using MinimalApi.Endpoint.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpoints();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCommands();
builder.Services.AddQueries();
builder.Services.AddApplicationServices();
builder.Services.AddDomainServices();

//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapEndpoints();
app.MapControllers();

app.Run();