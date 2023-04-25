using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using NLog;
using NLog.Web;
using System.Reflection;
using TaxiOperator.Business.Branch;
using TaxiOperator.Business.Cab;
using TaxiOperator.Business.Customer;
using TaxiOperator.Business.Driver;
using TaxiOperator.Business.Global;
using TaxiOperator.Business.Simulator;
using TaxiOperator.Entities.AppSetting;
using TaxiOperator.Extension;
using TaxiOperator.Filter;
using TaxiOperator.Repository.Branch;
using TaxiOperator.Repository.Simulator;
//using TaxiOperator.Repository.Data;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();
   // builder.Services.AddDbContext<DataContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings")); });
    builder.Services.AddControllers(options =>
    {
        //Error On Upload Excel Files
        options.MaxModelValidationErrors = 999999;
    });
    //builder.Configuration.AddJsonFile("appconnections.json", false, true);

    builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddMvc(options =>
    {

        options.EnableEndpointRouting = false;
        options.Filters.Add(typeof(ModelValidationFilter)); // validate method parameter model state with dataAnnotation 
    }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    { 
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "TaxiOperator API"
        });
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath, includeControllerXmlComments: true); 
        c.CustomSchemaIds(i => i.FullName);
    });



    builder.Logging.ClearProviders();
    builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
    builder.Host.UseNLog();
     
    builder.Services.AddSingleton<IGlobalBusiness, GlobalBusiness>();
    builder.Services.AddSingleton<IBranchBusiness, BranchBusiness>();
    builder.Services.AddSingleton<ICabBusiness, CabBusiness>();
    builder.Services.AddSingleton<ICustomerBusiness, CustomerBusiness>();
    builder.Services.AddSingleton<IDriverBusiness, DriverBusiness>();
    builder.Services.AddSingleton<ISimulatorBusiness, SimulatorBusiness>();
    builder.Services.AddSingleton<IBranchRepository, BranchRepository>();
    builder.Services.AddSingleton<ISimulatorRepository, SimulatorRepository>();
    builder.Services.AddSingleton<Microsoft.AspNetCore.Http.IHttpContextAccessor, HttpContextAccessor>(); 

    builder.Services.Configure<KestrelServerOptions>(options =>
    {
        options.AllowSynchronousIO = true;
    });

    builder.Services.Configure<IISServerOptions>(options =>
    {
        options.AllowSynchronousIO = true;
    });

    builder.Services.Configure<ApiBehaviorOptions>(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseLoggingMiddleware();
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception exception)
{
    // NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();

}