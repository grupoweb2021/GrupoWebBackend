using GrupoWebBackend.DomainPets.Models;
using Microsoft.EntityFrameworkCore;

namespace GrupoWebBackend.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Pet Constrains
            builder.Entity<Pet>().ToTable("Pets");
            builder.Entity<Pet>().HasKey(p => p.Id);
            builder.Entity<Pet>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Pet>().Property(p => p.Type).IsRequired();
            builder.Entity<Pet>().Property(p => p.Attention).IsRequired();
            builder.Entity<Pet>().Property(p => p.Race).IsRequired();
            builder.Entity<Pet>().Property(p => p.IsAdopted).IsRequired();
            
            // Pet Relations
            builder.Entity<Pet>().HasOne(p => p.User)
                .WithOne(p => p.Pet)
                .HasForeignKey<Pet>(p => p.UserId);
            // Pet Sample Data
            builder.Entity<Pet>().HasData
            (
                new Pet
                {
                    Id = 0,
                    Type = "Dog",
                    Name = "Tito",
                    Attention = "Required",
                    Race = "Caninus",
                    Age = 2,
                    IsAdopted = true,
                    UserId = 0
                }
            );


        }
        
    }
}