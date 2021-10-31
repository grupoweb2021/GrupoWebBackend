using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPublications.Models;
using GrupoWebBackend.DomainPublications.Services.Communications;

namespace GrupoWebBackend.DomainPublications.Services
{
    public interface IPublicationService
    {
        Task<IEnumerable<Publication>> ListPublicationAsync();
        Task<IEnumerable<Publication>> ListByUserId(int userId);
        Task<PublicationResponse> SaveAsync(Publication publication);
        Task<PublicationResponse> UpdateAsync(int id, Publication publication);
        Task<PublicationResponse> DeleteAsync(int id);
    }
}