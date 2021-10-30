using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainAdvertisements.Models;

namespace GrupoWebBackend.DomainAdvertisements.Repositories
{
    public interface IAdvertisementRepository
    {
        Task<IEnumerable<Advertisement>> ListAdvertisementAsync();
    }
}