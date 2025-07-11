﻿using Api.BackgroundServices;
using Application;
using Infrastructure;
using ISKI.Core.CrossCuttingConcerns.Exceptions.ExceptionHandling;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration.GetConnectionString("Default") ?? string.Empty);

builder.Services.AddControllers();
builder.Services.AddHostedService<PlcDataWorker>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

app.Run();
