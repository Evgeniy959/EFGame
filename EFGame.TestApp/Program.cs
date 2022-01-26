using EFGame.Lib;
using EFGame.Model;
using System;
using System.Linq;

namespace EFGame.TestApp
{
    class Program
    {
        static void Main()
        {
            var db = DataBase.Init();
            db.TabGames.Add(new Game
            {
                Name = "Counter-Strike",
                Creator = "Valve Corporation",
                Style = "Шутер от первого лица",
                DateOfRelease = "08.11.2000"
            });

            db.TabGames.Add(new Game
            {
                Name = "Warcraft: Orcs & Humans",
                Creator = "Blizzard Entertainment",
                Style = "Стратегия в реальном времени",
                DateOfRelease = "23.11.1994"
            });
            db.SaveChanges();
            var games = db.TabGames.ToList();
            Console.WriteLine("Список игр:");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Id}.{game.Name} - {game.Creator}-{game.Style}-{game.DateOfRelease}");
            }
        }
    }
}
