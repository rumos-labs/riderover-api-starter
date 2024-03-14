using Microsoft.EntityFrameworkCore;
using RideRover.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RideRoverDbContext>(options =>
{
    options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Database=RideRover;Integrated Security=sspi;");
    //options.UseSqlServer("Data Source=riderover-db.rumos.cloud;Database=RideRover;User Id=sa;Password=rumos123!;TrustServerCertificate=true;");
});

// TODO: Register services here

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();