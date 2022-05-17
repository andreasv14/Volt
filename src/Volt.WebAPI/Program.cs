using MediatR;
using Microsoft.AspNetCore.Mvc;
using Volt.Application;
using Volt.Application.Requests;
using Volt.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/categories", async ([FromServices] IMediator mediator) =>
{
    var result = await mediator.Send(new GetCategoriesRequest());

    return Results.Ok(result);
});

app.Run();