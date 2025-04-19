using EmprestimoLivro.API.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PlayNow.Domain.Interfaces;
using PlayNow.Persistence.Context;
using PlayNow.Persistence.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>(); // definindo a configuração da interface e quem a implementa para ser possível a injeção de dependência no ClienteRepository
builder.Services.AddAutoMapper(typeof(EntitiesToDTOMappingProfile));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "Versão .NET 8.0",
        Title = "APIRest PlayNow",
        Description = "APIRest criada servindo de Backend para o projeto mobile feito em Flutter",
        Contact = new OpenApiContact
        {
            Name = "Daniele Querino",
            Email = "danisq77@gmail.com",
        }
    });
});

builder.Services.AddDbContext<PlayNowDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
