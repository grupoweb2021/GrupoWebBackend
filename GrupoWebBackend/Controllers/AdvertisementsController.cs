using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainAdvertisements.Services;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Services;
using GrupoWebBackend.Extensions;
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
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveAdvertisementResource resource)
        {
            if (!ModelState.IsValid)
            
                return BadRequest(ModelState.GetErrorMessages());

            var advertisement = _mapper.Map<SaveAdvertisementResource, Advertisement>(resource);
            var result = await _advertisementService.SaveAsync(advertisement);

            if (!result.Success)
                return BadRequest(result.Message);


            var advertisementResource = _mapper.Map<Advertisement, AdvertisementResource>(result.Resource);
            return Ok(advertisementResource);
        }
        [HttpPut (template:"{id}")]
        public async Task<IActionResult> PutAsync (int id, [FromBody] SaveAdvertisementResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var advertisement = _mapper.Map<SaveAdvertisementResource, Advertisement>(resource);
            var result = await _advertisementService.UpdateAsync(id, advertisement);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = _mapper.Map<Advertisement, AdvertisementResource>(result.Resource);

            return Ok(categoryResource);
            
        }
     
        [HttpDelete(template:"{id}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var result = await _advertisementService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);
            var advertisementResourceResource = _mapper.Map<Advertisement, AdvertisementResource>(result.Resource);
            return Ok(advertisementResourceResource);
        }
    }
}