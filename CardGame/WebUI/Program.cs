
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        // Set up DI container
        var serviceProvider = new ServiceCollection()
            .AddSingleton<ICardRepository, InMemoryCardRepository>()
            .AddSingleton<Game>()
            .BuildServiceProvider();

        // Resolve and start the game
        var game = serviceProvider.GetService<Game>();
        game.StartGame();
        game.ShowHands();
    }
}