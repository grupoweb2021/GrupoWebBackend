using System.Collections.Generic;

namespace GrupoWebBackend.DomainPets.Models
{
    public class District
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        
        public IList<User> User { get; set; } = new List<User>();
    }
}