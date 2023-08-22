using Application;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using Persistence;
using Shared;
using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

//ServiceExtensions     
builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceInfraestructure(builder.Configuration);
builder.Services.AddSharedInfraestructure(builder.Configuration);
builder.Services.AddApiVersionExtension();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//---services maibe 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseErrorHandlerMiddleware();

app.MapControllers();

app.Run();
