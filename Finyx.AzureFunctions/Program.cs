using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Finyx.DAL.DbContext;
using Finyx.BLL.Abstraction;
using Finyx.BLL.IRepositories;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices((context, services) =>
    {
        // Configuration
        services.AddSingleton<IConfiguration>(context.Configuration);
        
        // Database Context
        services.AddDbContext<FinyxDbContext>(options =>
            options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
        
        // Core Services (commented out until implementations are created)
        //services.AddScoped<IUserService, UserService>();
        //services.AddScoped<IDocumentService, DocumentService>();
        //services.AddScoped<IReportingService, ReportingService>();
        //services.AddScoped<IEventProcessingService, EventProcessingService>();
        
        // Repositories (commented out until implementations are created)
        //services.AddScoped<IUserRepository, UserRepository>();
        //services.AddScoped<IDocumentRepository, DocumentRepository>();
        //services.AddScoped<IReportingRepository, ReportingRepository>();
        //services.AddScoped<IEventRepository, EventRepository>();
        //services.AddScoped<IGenericRepository<>, GenericRepository<>>();
        
        // Event Services (commented out until implementations are created)
        //services.AddScoped<IEventPublisher, EventPublisher>();
        //services.AddScoped<IEventSubscriber, EventSubscriber>();
        
        // Authentication
        services.AddAuthentication();
        services.AddAuthorization();
    })
    .Build();

host.Run();
