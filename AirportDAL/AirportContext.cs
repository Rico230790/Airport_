using AirportModels;
using System.Data.Entity;

namespace AirportDAL
{
    public class AirportContext : DbContext
    {
        public virtual DbSet<FlightM> Flights { get; set; }

        public virtual DbSet<Passenger> Passengers { get; set; }

        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightM>()
                .HasKey(l => l.Id)
                .HasMany(l => l.Tickets)
                .WithRequired(l => l.FlightM)
                .HasForeignKey(l => l.FlightId);

            modelBuilder.Entity<Ticket>()
                .HasKey(l => l.Id)
                .HasOptional(l => l.Passenger)
                .WithOptionalPrincipal(l => l.Ticket);

            modelBuilder.Entity<Passenger>()
                .HasKey(l => l.Id);

            base.OnModelCreating(modelBuilder);

        }
    }
}
