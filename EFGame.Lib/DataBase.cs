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

        public DataBase() { }

        public DataBase(DbContextOptions<DataBase> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        /*public static DataBase Init()
        {
            
        }*/
        public void Init()
        {
            //DbContextOptionsBuilder optionsBuilder = null;
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            if (!optionsBuilder.IsConfigured)
            {
                var str = File.ReadAllText("ConnectionString.txt");
                optionsBuilder.UseMySQL(str);
            }
        }
    }
}
