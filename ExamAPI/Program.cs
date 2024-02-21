using ExamAPI.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/* Database Context Injection */

var dbHost = Environment.GetEnvironmentVariable("DB_HOST") ;
var dbName =Environment.GetEnvironmentVariable("DB_NAME") ;
var dbPassword =Environment.GetEnvironmentVariable("DB_SA_PASSWORD") ;

// Setzen Sie den ServerCertificateValidationCallback
System.Net.ServicePointManager.ServerCertificateValidationCallback =
    (sender, certificate, chain, sslPolicyErrors) => { return true; };

var ConnectionString = $"Server={dbHost};Initial Catalog={dbName};User Id=sa;Password={dbPassword};Encrypt=False;";
/* ======================== */

builder.Services.AddDbContext<ExamContext>(options => options.UseSqlServer(ConnectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
