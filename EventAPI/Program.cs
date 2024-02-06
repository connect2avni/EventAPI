using EventData.DataContext;
using Microsoft.EntityFrameworkCore;
using EventBusiness.Services;
using EventData.Repository;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//add connection string
//read connection string from appsettings.json
string conStr= builder.Configuration.GetConnectionString("sqlcon");
builder.Services.AddDbContext<EventDbContext>(options => options.UseSqlServer(conStr));
builder.Services.AddScoped<EventBusiness.Services.EventService, EventBusiness.Services.EventService>();
builder.Services.AddScoped<IEventRepository,EventRepository>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();

