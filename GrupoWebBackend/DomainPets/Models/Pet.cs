﻿using GrupoWebBackend.DomainPublications.Models;

namespace GrupoWebBackend.DomainPets.Models
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

        public int UserId;
        public User User { get; set; }

        public int PublicationId;
        public Publication Publication;
    }
}
