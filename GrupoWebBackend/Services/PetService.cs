using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Repositories;
using GrupoWebBackend.DomainPets.Services;
using GrupoWebBackend.DomainPets.Services.Communications;

namespace GrupoWebBackend.Services
{
    public class PetService: IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task<IEnumerable<Pet>> ListPetAsync()
        {
            return await _petRepository.ListPetAsync();
        }

        public async Task<PetResponse> SaveAsync(Pet pet)
        {
            await _petRepository.AddAsync(pet);
            return new PetResponse(pet);
        }
    }
}