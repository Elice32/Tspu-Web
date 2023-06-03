using Microsoft.EntityFrameworkCore;
using TspuWeb.Repositories;

var builder = WebApplication.CreateBuilder(args);

Console.OutputEncoding = System.Text.Encoding.UTF8;


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepositoryInDataBase>();

builder.Services.AddDbContext<ApplicationDbContext> (options => 
options.UseNpgsql("Host=localhost; Port=5432; Database=tsput; Username=postgres; Password=7; "));

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();