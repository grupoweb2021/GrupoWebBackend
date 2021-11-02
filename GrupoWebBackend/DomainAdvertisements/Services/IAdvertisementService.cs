using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainAdvertisements.Services.Communications;

namespace GrupoWebBackend.DomainAdvertisements.Services
{
    public interface IAdvertisementService
    {
        Task<IEnumerable<Advertisement>> ListAdvertisementAsync();
        Task<IEnumerable<Advertisement>> ListByUserId(int userId);
        Task<AdvertisementResponse> SaveAsync(Advertisement advertisement);
        Task<AdvertisementResponse> UpdateAsync(int id, Advertisement advertisement);
        Task<AdvertisementResponse> DeleteAsync(int id);
    }
}