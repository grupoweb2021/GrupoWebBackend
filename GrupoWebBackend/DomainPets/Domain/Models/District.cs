using System.Collections.Generic;
using GrupoWebBackend.DomainUsers.Domain.Models;

namespace GrupoWebBackend.DomainPets.Domain.Models
{
    public class District
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        
        public IList<User> User { get; set; } = new List<User>();
    }
}