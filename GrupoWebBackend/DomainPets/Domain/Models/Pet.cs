﻿using GrupoWebBackend.DomainPublications.Domain.Models;
using GrupoWebBackend.DomainUsers.Domain.Models;

namespace GrupoWebBackend.DomainPets.Domain.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Attention { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public bool IsAdopted { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
    }
}