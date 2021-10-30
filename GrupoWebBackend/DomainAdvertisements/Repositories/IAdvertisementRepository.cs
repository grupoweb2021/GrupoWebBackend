using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainAdvertisements.Models;

namespace GrupoWebBackend.DomainAdvertisements.Repositories
{
    public interface IAdvertisementRepository
    {
        Task<IEnumerable<Advertisement>> ListAdvertisementAsync();
        Task AddAsync(Advertisement advertisement);
        Task<Advertisement> FindByIdAsync(int id);
        void Update(Advertisement advertisement);
        void Remove(Advertisement advertisement);
        Task<Advertisement> FindByTitleAsync(string title);
        Task<IEnumerable<Advertisement>> FindByUserId(int userId);
    }
}