
using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainAdvertisements.Services;

namespace GrupoWebBackend.Services
{
    public class AdvertisementService: IAdvertisementService
    {
        private readonly IAdvertisementService _advertisementService;
        public AdvertisementService(IAdvertisementService advertisementService)
        {
            _advertisementService = advertisementService;
        }
        public async Task<IEnumerable<Advertisement>> ListAdvertisementAsync()
        {
            return await _advertisementService.ListAdvertisementAsync();
        }

        public async Task<IEnumerable<Advertisement>> ListByUserId(int userId)
        {
            return await _advertisementService.ListByUserId(userId);
        }
    }
}