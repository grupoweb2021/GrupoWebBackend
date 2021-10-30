using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Services;
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
        public async Task<IEnumerable<PetResource>> GetAllPetsAsync()
        {
            var pets = await _petService.ListPetAsync();
            var resources = _mapper.Map<IEnumerable<Pet>, IEnumerable<PetResource>>(pets);
            return resources;
        }
        
        
        
    }
}