using SistemaDeTarefas.Data;
using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Repositorios.Interfaces;
using SistemaDeTarefas.Repositorios;
using Npgsql;

namespace SistemaDeTarefas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkNpgsql()
                .AddDbContext<SistemaDeTarefasDBContext>(
                    options => options.UseNpgsql(builder.Configuration.GetConnectionString("DataBase")) //Configuração do banco de dados para coincidir com as informações do json
                );

            builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>(); //Configuração da injeção de dependencia

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
        }
    }
}