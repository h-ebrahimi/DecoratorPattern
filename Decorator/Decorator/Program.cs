// See https://aka.ms/new-console-template for more information

using Decorator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

var builder = new HostBuilder();
builder.ConfigureServices((context, service) =>
{
    service.AddScoped<ICustomAction, CustomAction>();
    service.Decorate<ICustomAction, DecoratorCustomAction>();
});

var host = builder.Build();
host.RunAsync();
var service = host.Services.CreateScope().ServiceProvider.GetRequiredService<ICustomAction>();

var number = 1;
while (number > 0)
{
    Console.Write("Number : ");
    number = int.Parse(Console.ReadLine());
    service.Do(number);
}

Console.ReadLine();