using GrupoWebBackend.DomainPublications.Domain.Models;
using GrupoWebBackend.Security.Domain.Entities;

namespace GrupoWebBackend.DomainAdoptionsRequests.Domain.Models
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