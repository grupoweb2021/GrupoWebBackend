using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainAdvertisements.Services;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Services;
using GrupoWebBackend.Resources;
using Microsoft.AspNetCore.Mvc;
namespace GrupoWebBackend.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class AdvertisementsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAdvertisementService _advertisementService;

        public AdvertisementsController(IMapper mapper,IAdvertisementService advertisementService)
        {
            _mapper = mapper;
            _advertisementService = advertisementService;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Advertisement>>GetAllAdvertisements()
        {
            var _advertisements = await _advertisementService.ListAdvertisementAsync();
            var resources = _mapper.Map<IEnumerable<Advertisement>, IEnumerable<AdvertisementResource>>(_advertisements);
            return _advertisements;

        }
        
    }
}