namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=ConcertSystemDB")
        {
        }

        public virtual DbSet<Concert> Concert { get; set; }
        public virtual DbSet<Organizer> Organizer { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Concert>()
                .HasMany(e => e.Ticket)
                .WithRequired(e => e.Concert)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organizer>()
                .HasMany(e => e.Concert)
                .WithRequired(e => e.Organizer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Place>()
                .HasMany(e => e.Concert)
                .WithRequired(e => e.Place)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
