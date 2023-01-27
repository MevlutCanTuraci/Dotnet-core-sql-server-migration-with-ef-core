using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using DataAccessLayout.Context;

var builder = WebApplication.CreateBuilder(args);

//Contexts Here adding Data Context file and sql server connection string
builder.Services.AddDbContext<DataContext>(op => op.UseSqlServer(
    "Server=(local);Database=<Your-database-name>;User Id=<your-user-name>;Password=<your-password>;Integrated Security=true;Encrypt=true;Column Encryption Setting=Enabled;Trust Server Certificate=true;"
    )
);

// Add services to the container.

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
