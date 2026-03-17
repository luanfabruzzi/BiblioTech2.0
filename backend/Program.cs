using BiblioTech.Api.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// ====================== CONFIGURAÇÃO ======================
builder.Services.AddControllers()
    .AddJsonOptions(options => 
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    { 
        Title = "BiblioTech API", 
        Version = "v1",
        Description = "Sistema de Gestão Bibliotecária - Clean Architecture"
    });
});

// Banco de Dados (PostgreSQL)
builder.Services.AddDbContext<BiblioTechDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

// FluentValidation
builder.Services.AddFluentValidationAutoValidation();

// JWT Authentication
builder.Services.AddAuthentication()
    .AddJwtBearer(); // Configuração completa em Extensions mais abaixo

// ====================== INJEÇÃO DE DEPENDÊNCIAS ======================
builder.Services.AddApplicationServices();     // ← Vamos criar essa extensão depois
builder.Services.AddInfrastructureServices();  // ← Vamos criar essa extensão depois

var app = builder.Build();

// ====================== PIPELINE ======================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();