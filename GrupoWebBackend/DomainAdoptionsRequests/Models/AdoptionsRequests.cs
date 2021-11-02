using GrupoWebBackend.DomainPublications.Models;
using GrupoWebBackend.DomainPets.Models;

namespace GrupoWebBackend.DomainAdoptionsRequests.Models
{
    public class AdoptionsRequests
    {
        public int Id { get; set; }
        
        public string Message { get; set; }

        public string Status { get; set; }
        
        public int UserId;
        public User User { get; set; }
        
        public int PublicationId;
        public Publication Publication;
    }
}