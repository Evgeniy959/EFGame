using EFGame.Lib;
using EFGame.Model;
using System;

namespace EFGame.TestApp
{
    class Program
    {
        static void Main()
        {
            /*var db = new DataBase();
            db.Init();*/
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
        }
    }
}
