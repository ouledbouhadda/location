using Microsoft.EntityFrameworkCore;

namespace projetDev.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<House> Houses { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Définition explicite du type decimal avec précision (18,2)
            modelBuilder.Entity<House>()
                .Property(h => h.PricePerNight)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Reservation>()
                .Property(r => r.TotalPrice)
                .HasColumnType("decimal(18,2)");
        }
    }
}
