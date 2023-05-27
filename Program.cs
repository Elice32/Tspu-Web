using Microsoft.EntityFrameworkCore;
using TspuWeb.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepositoryInDataBase>();

builder.Services.AddDbContext<ApplicationDbContext> (options => 
options.UseNpgsql("Host=localhost; Port=5432; Database=tsput; Username=postgres; Password=admin; "));

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