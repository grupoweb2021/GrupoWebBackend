using System.Collections.Generic;
using GrupoWebBackend.DomainAdoptionsRequests.Models;
using GrupoWebBackend.DomainPets.Models;

namespace GrupoWebBackend.DomainPublications.Models
{
    public class Publication
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string DateTime { get; set; }
        public string Comment { get; set; }

        public IList<AdoptionsRequests> AdoptionsRequestsList { get; set; } = new List<AdoptionsRequests>();
        public IList<Pet> Pets { get; set; } = new List<Pet>();

    }
}