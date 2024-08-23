using ContactApi.Service;
using Domain.Interfaces;
using Domain.Interfaces.Service;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IUnitOfWork, UnitofWork>();
builder.Services.AddDbContext<ContactContext>(options => options.UseSqlServer("Server=MELTED;Database=Contact;Trusted_Connection=True;Encrypt=false;"));
builder.Services.AddSwaggerGen();

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
