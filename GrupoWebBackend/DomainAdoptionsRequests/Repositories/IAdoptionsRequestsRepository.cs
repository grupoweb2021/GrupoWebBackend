using GrupoWebBackend.DomainAdoptionsRequests.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GrupoWebBackend.DomainAdoptionsRequests.Repositories
{
    public interface IAdoptionsRequestsRepository
    {
        Task<IEnumerable<AdoptionsRequests>> ListAdoptionsRequestsAsync();

        Task AddAsync(AdoptionsRequests adoptionsRequests);

        Task<AdoptionsRequests> FindByIdAsync(int id);

        void Update(AdoptionsRequests adoptionsRequests);
        
        void Remove(AdoptionsRequests adoptionsRequests);

       // Task<IEnumerable<AdoptionsRequests>> FindByAdoptionsRequests(int adoptionsRequestsId);

    }
}