using cinema_2.com.nure.models;
using Microsoft.EntityFrameworkCore;

namespace cinema_2.db
{
    class MySqlDbContext : DbContext
    {
        public DbSet<Room> Room { get; set; }
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
            optionsBuilder.UseMySQL("server=localhost;database=cinema;user=root;password=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.Property(r => r.Id).IsRequired().HasColumnName("room_id");
                entity.Property(r => r.Name).IsRequired().HasColumnName("name");
                entity.Property(r => r.Row).IsRequired().HasColumnName("row");
                entity.Property(r => r.Column).IsRequired().HasColumnName("number_in_row");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).IsRequired().HasColumnName("customer_id");
                entity.Property(c => c.FirstName).IsRequired().HasColumnName("first_name");
                entity.Property(c => c.LastName).IsRequired().HasColumnName("last_name");
                entity.Property(c => c.Phone).IsRequired().HasColumnName("phone");
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(f => f.Id);
                entity.Property(f => f.Id).IsRequired().HasColumnName("film_id");
                entity.Property(f => f.Name).IsRequired().HasColumnName("name");
                entity.Property(f => f.Duration).IsRequired().HasColumnName("duration");
                entity.Property(f => f.FirstPerformance).HasColumnName("first_performance");
                entity.Property(f => f.Country).HasColumnName("country");
                entity.Property(f => f.Genre).HasColumnName("genre");
                entity.Property(f => f.Cost).HasColumnName("cost");
                entity.Property(f => f.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Session>(entity => {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Id).IsRequired().HasColumnName("session_id");
                //entity.HasOne<Film>(s => s.Film).H
                entity.HasOne<Film>(s => s.Film).WithMany(f => f.Sessions).HasForeignKey(s => s.FilmId);
                entity.HasOne<Room>(s => s.Room).WithMany(r => r.Sessions).HasForeignKey(s => s.RoomId);
                entity.Property(s => s.DateTime).IsRequired().HasColumnName("date_time");
            });

            modelBuilder.Entity<Booking>(entity => {
                entity.HasKey(b => b.Id);
                entity.Property(b => b.Id).IsRequired().HasColumnName("booking_id");
                entity.HasOne(b => b.Session).WithOne().HasForeignKey(typeof(Session).ToString(), "session_id");
                entity.HasOne(b => b.Customer).WithOne().HasForeignKey(typeof(Customer).ToString(), "customer_id");
                entity.Property(b => b.Row).IsRequired().HasColumnName("row");
                entity.Property(b => b.SeatNumber).IsRequired().HasColumnName("seat_number");
            });
        }
    }
}