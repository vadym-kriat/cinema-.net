using cinema_2.com.nure.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using MySql.Data.Entity;

namespace cinema_2.db
{
    public class MySqlDbContext : DbContext
    {
        public DbSet<Genre> Genre { get; set; }

        public MySqlDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=cinema;user=root;password=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(g => g.Id);
                entity.Property(g => g.Id).IsRequired().HasColumnName("genre_id");
                entity.Property(g => g.Name).IsRequired().HasColumnName("name");
            });
        }
    }
}