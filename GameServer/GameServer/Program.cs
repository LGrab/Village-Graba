using Domain;
using Domain.Buildings;
using Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Technology.Http;

var builder = WebApplication.CreateBuilder(args);

//Dependency inversion
builder.Services.AddSingleton<IResponseValues, Responsevalues>();
builder.Services.AddSingleton<ITest, Test>();
builder.Services.AddSingleton<HttpGameServer>();

builder.Services.AddSingleton<Game>();
builder.Services.AddSingleton<BuildingProvider>();


HttpGameServer.Create(builder);

var app = builder.Build();

// Configure the HTTP request pipeline
var gameServer = app.Services.GetRequiredService<HttpGameServer>();

gameServer.MapRequests(app);


// Start the server
app.Services.GetRequiredService<Game>().RunGame();//todo: Jak to nastartovat hru skrz dotnet infratrukturu apod
await app.RunAsync();

