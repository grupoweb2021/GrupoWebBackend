using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainAdvertisements.Models;

namespace GrupoWebBackend.DomainAdvertisements.Services
{
    public interface IAdvertisementService
    {
        Task<IEnumerable<Advertisement>> ListAdvertisementAsync();
        Task<IEnumerable<Advertisement>> ListByUserId(int userId);
    }
}