// Program.cs

using E_Commerce.Infrastructure.Persistence.Context;
using E_Commerce_Project.Extensions;
using E_Commerce.Infrastructure.Persistence;
using E_Commerce.Services;


namespace E_Commerce_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.ConfigurePersistence(builder.Configuration);
            builder.Services.ConfigureApplication();

            builder.Services.ConfigureApiBehavior();
            builder.Services.ConfigureCorsPolicy();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            var serviceScope = app.Services.CreateScope();
            var dataContext = serviceScope.ServiceProvider.GetService<DataContext>();
            dataContext?.Database.EnsureCreated();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseErrorHandler();
            app.UseCors();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}