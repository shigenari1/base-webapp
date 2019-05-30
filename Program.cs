using System;
using src.ConsoleApp;
using src.ConsoleApp.User;
using Microsoft.Extensions.DependencyInjection;

namespace csharp
{
    class Program
    {
        static void Main (string[] args)
        {
            Startup.Run();
            var serviceCollection = Startup.ServiceCollection;
            var serviceProvider = serviceCollection.BuildServiceProvider();
            Console.WriteLine("=======================================");
            Console.WriteLine("Welcome to sample of clean architecture");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine("Enter the name of the new user.");
            Console.WriteLine("username:");
            Console.Write(">");
            var username = Console.ReadLine();
            var controller = serviceProvider.GetService<UserController>();
            controller.CreateUser(username);
            Console.WriteLine("press any key to exit.");
            Console.ReadKey();

        }
    }
}