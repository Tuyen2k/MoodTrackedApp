using Microsoft.EntityFrameworkCore;
using MoodTrackedApi.Repositories;
using MoodTrackedApi.Repositories.Interface;
using MoodTrackedApi.Services;
using MoodTrackedApi.Services.Implement;
using MoodTrackedLib;

var builder = WebApplication.CreateBuilder(args);

// Add services DI in Project
builder.Services.AddScoped<IUserRepositories, UserRepositories>();
builder.Services.AddScoped<IUserServices, UserServices>();

// Add services to the container.
builder.Services.AddDbContext<MoodTrackedDBContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("MoodTrackedDb"));
});

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
