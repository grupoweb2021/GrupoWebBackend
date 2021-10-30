using GrupoWebBackend.DomainAdvertisements.Models;
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
        public DbSet<Advertisement>Advertisements { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Pet Constraints
            builder.Entity<Pet>().ToTable("Pets");
            builder.Entity<Pet>().HasKey(p => p.Id);
            builder.Entity<Pet>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Pet>().Property(p => p.Type).IsRequired();
            builder.Entity<Pet>().Property(p => p.Attention).IsRequired();
            builder.Entity<Pet>().Property(p => p.Race).IsRequired();
            builder.Entity<Pet>().Property(p => p.IsAdopted).IsRequired();
            //Advertisement Constraints
            builder.Entity<Advertisement>().ToTable("Advertisements");
            builder.Entity<Advertisement>().HasKey(p => p.Id);
            builder.Entity<Advertisement>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Advertisement>().Property(p => p.Description).HasMaxLength(200).IsRequired();
            builder.Entity<Advertisement>().Property(p => p.Promoted).IsRequired();
            builder.Entity<Advertisement>().Property(p => p.DateTime).IsRequired();
            builder.Entity<Advertisement>().Property(p => p.UrlToImage).IsRequired();
            builder.Entity<Advertisement>().Property(p => p.Discount);
            builder.Entity<Advertisement>().Property(p => p.Title).HasMaxLength(70).IsRequired();
            builder.Entity<Advertisement>().Property(p => p.UserId).IsRequired();
            
            // Pet Relations
            builder.Entity<Pet>().HasOne(p => p.User)
                .WithOne(p => p.Pet)
                .HasForeignKey<Pet>(p => p.UserId);
            //Advertisement Relations
            builder.Entity<Advertisement>().HasOne(p => p.User)
                .WithOne(p => p.Advertisement)
                .HasForeignKey<Advertisement>(p => p.UserId);

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
           //Advertisement Sample Data
           builder.Entity<Advertisement>().HasData
           (
               new Advertisement
               {
                   Id= 0,
                   UserId = 1,
                   DateTime= "29/09/2021 16:20",
                   Title = "this is a title",
                   Description = "add description",
                   Discount = 10,
                   UrlToImage = "https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg",
                   Promoted = true
               }
           );

        }
        
    }
}