using EFGame.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace EFGame.Lib
{
    public sealed class DataBase : DbContext
    {
        public DbSet<Game> TabGames { get; set; }

        protected DataBase() { }

        public DataBase(DbContextOptions<DataBase> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public static DataBase Init()
        {
            DbContextOptionsBuilder<DataBase> optionsBuilder = new DbContextOptionsBuilder<DataBase>();
            if (!optionsBuilder.IsConfigured)
            {
                var str = File.ReadAllText("ConnectionString.txt");
                var options = optionsBuilder.UseMySQL(str).Options;
                return new DataBase(options);
            }
            return new DataBase();
        }
    }
}
