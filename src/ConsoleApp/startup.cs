using src.ConsoleApp.User;
using src.ConsoleApp.User.Create;
using src.Domain.Application.User;
using src.Domain.Domain.Users;
using src.InMemoryUserInfrastructure.Users;
using Microsoft.Extensions.DependencyInjection;
using src.MySqlInfrastructure.Users;
using src.UseCase.User.Create;

namespace src.ConsoleApp
{
    public static class Startup
    {
        public static IServiceCollection ServiceCollection {get; } = new ServiceCollection();
        
        public static void Run()
        {
#if DEBUG
            setupDebug();
#else
            setupProduct();
#endif
        }

        private static void setupProduct()
        {
            ServiceCollection.AddTransient<IUserRepository, UserRepository>();
            ServiceCollection.AddTransient<IUserCreatePresenter, UserCreatePresenter>();
            ServiceCollection.AddTransient<IUserCreateUseCase, UserCreateInteractor>();
            ServiceCollection.AddTransient<UserController>();

        }

        private static void setupDebug()
        {
            ServiceCollection.AddTransient<IUserRepository, InMemoryUserRepository>();
            ServiceCollection.AddTransient<IUserCreatePresenter, UserCreatePresenter>();
            ServiceCollection.AddTransient<IUserCreateUseCase, UserCreateInteractor>();
            ServiceCollection.AddTransient<UserController>();
        }

    }
}

