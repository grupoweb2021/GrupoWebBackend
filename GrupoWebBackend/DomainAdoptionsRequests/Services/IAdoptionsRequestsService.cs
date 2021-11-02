using GrupoWebBackend.DomainAdoptionsRequests.Models;
using GrupoWebBackend.DomainAdoptionsRequests.Services.Communications;

using System.Threading.Tasks;
using System.Collections.Generic;
namespace GrupoWebBackend.DomainAdoptionsRequests.Services
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