using FileWatcherService;
using Microsoft.Extensions.Hosting;
using Serilog;



Log.Logger = new LoggerConfiguration()
.WriteTo.Console()
.WriteTo.File("logs/filewatcher.txt", rollingInterval: RollingInterval.Day)
.CreateLogger();

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
