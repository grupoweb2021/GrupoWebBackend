﻿using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPublications.Models;
using GrupoWebBackend.DomainAdoptionsRequests.Models;
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
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<AdoptionsRequests> AdoptionsRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Pet Constraints
            builder.Entity<Pet>().ToTable("Pets");
            builder.Entity<Pet>().HasKey(p => p.Id);
            builder.Entity<Pet>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Pet>().Property(p => p.Type).IsRequired();
            builder.Entity<Pet>().Property(p => p.Name).IsRequired();
            builder.Entity<Pet>().Property(p => p.Attention).IsRequired();
            builder.Entity<Pet>().Property(p => p.Age).IsRequired();
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
            //Publications Constraints
            builder.Entity<Publication>().ToTable("Publications");
            builder.Entity<Publication>().HasKey(p => p.Id);
            builder.Entity<Publication>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Publication>().Property(p => p.DateTime).IsRequired();
            builder.Entity<Publication>().Property(p => p.UserId).IsRequired();
            builder.Entity<Publication>().Property(p => p.PetId).IsRequired();
            builder.Entity<Publication>().Property(p => p.Comment).HasMaxLength(70).IsRequired();
            //AdoptionsRequests
            builder.Entity<AdoptionsRequests>().ToTable("AdoptionsRequests");
            builder.Entity<AdoptionsRequests>().HasKey(p => p.Id);
            builder.Entity<AdoptionsRequests>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<AdoptionsRequests>().Property(p => p.Message).IsRequired();
            builder.Entity<AdoptionsRequests>().Property(p => p.Message).HasMaxLength(300).IsRequired();
            builder.Entity<AdoptionsRequests>().Property(p => p.Status).IsRequired();

            
            // Districts
            builder.Entity<District>().ToTable("Districts");
            builder.Entity<District>().HasKey(p => p.Id);
            builder.Entity<District>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<District>().Property(p => p.DistrictName).IsRequired();

            // District Relationship
            builder.Entity<District>().HasMany(p => p.User)
                .WithOne(p => p.District)
                .HasForeignKey(p => p.DistrictId);
            
            // Pet Relations
            builder.Entity<User>().HasMany(p => p.Pets)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
            
            //Advertisement Relations
            builder.Entity<User>().HasMany(p => p.Advertisements)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            //User Relationships
            builder.Entity<User>().HasMany(p => p.Publications)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            //Publication Relations
            builder.Entity<Publication>().HasMany(p => p.Pets)
                .WithOne(p => p.Publication)
                .HasForeignKey(p => p.PublicationId);

            //AdoptionsRequests Relations 
            builder.Entity<Publication>().HasMany(p => p.AdoptionsRequestsList)
                .WithOne(p => p.Publication)
                .HasForeignKey(p => p.PublicationId);
            
            //AdoptionsRequests Relations 
            builder.Entity<User>().HasMany(p => p.AdoptionsRequestsList)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);


            builder.Entity<District>().HasData(
                new District
                {
                    Id = 1,
                    DistrictName = "Ventanilla"
                },
                new District
                {
                    Id = 2,
                    DistrictName = "San Miguel"
                }
            );
            
            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Type = "VET",
                    UserNick = "Frank",
                    Pass = "Don't know",
                    Ruc = "A12345rf",
                    Dni = "70258688",
                    Phone = "946401234",
                    Email = "frank@outlook.com",
                    Name = "Francisco",
                    LastName = "Voularte",
                    DistrictId = 1
                    //PetId = 100
                }
            );
            // Pet Sample Data
            builder.Entity<Pet>().HasData
            (
                new Pet
                {
                    Id = 100,
                    Type = "Dog",
                    Name = "Tito",
                    Attention = "Required",
                    Race = "Caninus",
                    Age = 2,
                    IsAdopted = true,
                    UserId = -1,
                    PublicationId = 2
                },
                new Pet
                {
                    Id = 101,
                    Type = "Cat",
                    Name = "Lolo",
                    Attention = "Required",
                    Race = "Catitus",
                    Age = 2,
                    IsAdopted = true,
                    UserId = 1,
                    PublicationId = 1
                }
            );

            //Advertisement Sample Data
            builder.Entity<Advertisement>().HasData
            (
                new Advertisement
                {
                    Id = 1,
                    UserId = 1,
                    DateTime = "29/09/2021 16:20",
                    Title = "this is a title",
                    Description = "add description",
                    Discount = 10,
                    UrlToImage = "https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg",
                    Promoted = true
                }
            );
            //User SampleData

            //Publications SampleData
            builder.Entity<Publication>().HasData
            (
                new Publication()
                {
                    Id = 1,
                    UserId = 1,
                    DateTime = "29/09/2021 16:20",
                    PetId = 101,
                    Comment = "this is a comment"
                },
                new Publication()
                {
                    Id = 2,
                    UserId = 1,
                    DateTime = "29/09/2021 16:20",
                    PetId = 100,
                    Comment = "this is a comment"
                },
                new Publication()
                {
                    Id = 3,
                    UserId = 1,
                    DateTime = "29/09/2021 16:20",
                    PetId = -1,
                    Comment = "this is a comment"
                }
            );

            //AdoptionsRequests SampleData

            builder.Entity<AdoptionsRequests>().HasData(
                new AdoptionsRequests()
                {
                    Id = 1,
                    Message = "hola",
                    Status = "pending",
                    //UserId = -1,
                    //PublicationId = -1
                }
            );
        }
    }
}