
using System.Globalization;
using M1S3_SistemaBanco.Model;
using M1S3_SistemaBanco.Services;
using M1S3_SistemaBanco.Interface;

var builder = WebApplication.CreateBuilder();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClienteService, ClienteService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();