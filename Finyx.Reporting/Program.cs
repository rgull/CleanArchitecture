
using Microsoft.EntityFrameworkCore;
using Finyx.DAL.DbContext;
using Finyx.BLL.Abstraction;
using Finyx.BLL.IRepositories;

namespace Finyx.Reporting
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

            // Database Context
            builder.Services.AddDbContext<FinyxDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Reporting Services (commented out until implementations are created)
            //builder.Services.AddScoped<IReportingService, ReportingService>();
            //builder.Services.AddScoped<IReportingRepository, ReportingRepository>();

            // PDF Template Services (commented out until implementations are created)
            //builder.Services.AddScoped<ITemplateService, TemplateService>();
            //builder.Services.AddScoped<IPdfGeneratorService, PdfGeneratorService>();

            // CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowAll");
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
