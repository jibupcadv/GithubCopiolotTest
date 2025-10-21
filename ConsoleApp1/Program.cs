// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<IService, Service>();
serviceCollection.AddTransient<IService2, Service2>();
var serviceProvider = serviceCollection.BuildServiceProvider();

IService service = serviceProvider.GetService<IService>();
service.Execute();
service.Execute2();
