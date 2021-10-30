using System.Collections.Generic;

namespace GrupoWebBackend.DomainPets.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int DistrictId { get; set; }
        public District District { get; set; }
        
        public IList<User> User { get; set; } = new List<User>();
    }
}