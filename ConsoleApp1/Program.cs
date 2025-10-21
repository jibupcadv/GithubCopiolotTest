// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");
var services = new ServiceCollection();
services.AddTransient<IService, Service>();
services.AddTransient<IService2, Service2>();

var provider = services.BuildServiceProvider();

IService service = provider.GetRequiredService<IService>();
service.Execute();
service.ExecuteService2();
