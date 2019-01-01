using cinema_2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cinema_2.db
{
    class MySqlDbContext : DbContext
    {
        public DbSet<Room> Room { get; set; }
        public DbSet<Row> Row { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Booking> Booking { get; set; }

        public MySqlDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=cinema;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Row>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.Property(r => r.Seats).IsRequired();
                entity.Property(r => r.Number).IsRequired();
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.Property(r => r.Name).IsRequired();
                entity.HasMany(r => r.Rows).WithOne(r => r.Room).IsRequired();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.FirstName).IsRequired();
                entity.Property(c => c.LastName).IsRequired();
                entity.Property(c => c.Phone);
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(f => f.Id);
                entity.Property(f => f.Name).IsRequired();
                entity.Property(f => f.Description);
                entity.Property(f => f.Duration).IsRequired();
                entity.Property(f => f.FirstPerformance);
                entity.Property(f => f.Country);
                entity.Property(f => f.Genre);
                entity.Property(f => f.Cost);
                entity.Property(f => f.Type);
                entity.Property(f => f.Image);
            });

            modelBuilder.Entity<Session>(entity => {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.DateTime).IsRequired();
            });

            modelBuilder.Entity<Booking>(entity => {
                entity.HasKey(b => b.Id);
                entity.Property(b => b.Row).IsRequired();
                entity.Property(b => b.Seat).IsRequired();
            });
        }
    }
}