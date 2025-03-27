using Microsoft.EntityFrameworkCore;
using projetDev.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuration de la base de données (évite le doublon)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configuration CORS pour autoriser Angular
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:4200") // Angular tourne sur ce port
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();

// Activation de CORS
app.UseCors("AllowAngular");

// Configure le pipeline de requêtes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
