
using Healthcare.Api.Builders;
using Healthcare.IoC;

namespace Healthcare.Api
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
            builder.Services.AddDependency(builder.Configuration);    
            builder.Services.AddCors(cors => 
            {
                cors.AddDefaultPolicy(policy => 
                {
                    policy.SetIsOriginAllowedToAllowWildcardSubdomains()
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowAnyOrigin()
                          .Build();
                });
            });
                    

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseApplyMigrations();
            app.UseHttpsRedirection();

            app.UseRouting();
            
            app.UseCors();
            app.UseStatusCodePages();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}