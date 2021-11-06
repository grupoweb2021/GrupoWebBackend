using System.Collections.Generic;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainPublications.Models;
using GrupoWebBackend.DomainAdoptionsRequests.Models;
namespace GrupoWebBackend.DomainPets.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string UserNick { get; set; }
        public string Pass { get; set; }
        public string Ruc { get; set; }
        public string Dni { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int DistrictId { get; set; }
        
        public District District { get; set; }
        
        // public int LocationId { get; set; }
        // public Location Location { get; set; }
        public IList<Pet> Pets { get; set; } = new List<Pet>();
        public IList<Advertisement> Advertisements { get; set; } = new List<Advertisement>();
        public IList<Publication> Publications { get; set; }=new List<Publication>();
        public IList<AdoptionsRequests> AdoptionsRequestsList { get; set; } = new List<AdoptionsRequests>();
    }
}