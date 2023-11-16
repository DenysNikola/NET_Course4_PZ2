using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class MyDbContext : DbContext  
    {
        public DbSet<Anime> Anime { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserAnimeList> UserAnimeList { get; set; }


        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define a foreign key relationship between UserAnimeList and User
            modelBuilder.Entity<UserAnimeList>()
                .HasOne(ual => ual.User)
                .WithMany(u => u.UserAnimeList)
                .HasForeignKey(ual => ual.UserID);

            // Define a foreign key relationship between UserAnimeList and Anime
            modelBuilder.Entity<UserAnimeList>()
                .HasOne(ual => ual.Anime)
                .WithMany(a => a.UserAnimeList)
                .HasForeignKey(ual => ual.AnimeID);
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\nure\\course4\\csharp\\Mal_Data\\mal_clone.db");
        }
    }
}
