using Microsoft.EntityFrameworkCore;
using RestApi.Models;
using Pomelo.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddControllers();
builder.Services.AddDbContext<CitiesContext>(opt =>
    opt.UseMySql(connection, ServerVersion.AutoDetect(connection)));
builder.Services.AddDbContext<StreetsContext>(opt =>
    opt.UseMySql(connection, ServerVersion.AutoDetect(connection)));
builder.Services.AddDbContext<HousesContext>(opt =>
    opt.UseMySql(connection, ServerVersion.AutoDetect(connection)));
builder.Services.AddDbContext<ApartmentsContext>(opt =>
    opt.UseMySql(connection, ServerVersion.AutoDetect(connection)));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
