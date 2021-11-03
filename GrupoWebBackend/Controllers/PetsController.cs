using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Services;
using GrupoWebBackend.DomainPublications.Models;
using GrupoWebBackend.Extensions;
using GrupoWebBackend.Resources;
using Microsoft.AspNetCore.Mvc;

namespace GrupoWebBackend.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPetService _petService;

        public PetsController(IMapper mapper, IPetService petService)
        {
            _mapper = mapper;
            _petService = petService;
        }

        [HttpGet]
        public async Task<IEnumerable<Pet>> ListAsync()
        {
            var pets = await _petService.ListAsync();
            return pets;
        }

        // [HttpGet("{id:int}")]
        // public async Task<Pet> FindAsync(int id)
        // {
        //     var pet = await _petService.FindAsync(id);
        //     return pet;
        // }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SavePetResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            
            var pet = _mapper.Map<SavePetResource, Pet>(resource);
            var result = await _petService.AddAsync(pet);
            
            if (!result.Succces)
                return BadRequest(result.Message);
            
            var petResource = _mapper.Map<Pet, PetResource>(result.Pet);
            return Ok(petResource);
        }
        
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutAsync ([FromBody] SavePetResource resource, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var pet = _mapper.Map<SavePetResource, Pet>(resource);
            var result = await _petService.UpdateAsync(pet, id);

            if (!result.Success)
                return BadRequest(result.Message);

            var petResource = _mapper.Map<Pet, PetResource>(result.Resource);

            return Ok(petResource);
            
        }
        
    }
}