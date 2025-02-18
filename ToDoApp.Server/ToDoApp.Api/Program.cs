using Microsoft.EntityFrameworkCore;
using ToDoApp.Api.Extensions;
using ToDoList.Application.Helpers;
using ToDoList.Infrastructure.Dal;
using ToDoList.Infrastructure.Dal.Entities;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(AppMappingProfile));
builder.Services.AddOptionConfiguration(config);
builder.Services.AddIdentityConfiguration();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapIdentityApi<UserEntity>();
app.Run();
