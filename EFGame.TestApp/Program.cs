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
                Name = "Genshin Impact",
                Creator = "MiHoYo",
                Style = "action-adventure с открытым миром и элементами RPG",
                DateOfRelease = "13.01.2020"
            });
            db.TabGames.Add(new Game
            {
                Name = "GTA 5",
                Creator = "Rockstar North",
                Style = "Action-adventure, или приключенческий боевик",
                DateOfRelease = "17.09.2013"
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
