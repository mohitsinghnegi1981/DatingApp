using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(opt => {

    opt.UseSqlite(builder.Configuration.GetConnectionString("defaultConnection"));

});

var app = builder.Build();

app.MapControllers();

app.Run();
