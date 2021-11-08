using GrupoWebBackend.DomainAdoptionsRequests.Domain.Models;
using GrupoWebBackend.DomainAdoptionsRequests.Domain.Services.Communications;

using System.Threading.Tasks;
using System.Collections.Generic;
namespace GrupoWebBackend.DomainAdoptionsRequests.Domain.Services
{
    public interface IAdoptionsRequestsService
    {
        Task<IEnumerable<AdoptionsRequests>> ListAdoptionsRequestsAsync();

      //  Task<IEnumerable<AdoptionsRequests>> ListByUserId(int userId);

        Task<AdoptionsRequestsResponse> SaveAsync(AdoptionsRequests adoptionsRequest);

        Task<AdoptionsRequestsResponse> DeleteAsync(int id);
        
        Task<AdoptionsRequestsResponse> UpdateAsync(int id,AdoptionsRequests adoptionsRequest);

    }
}