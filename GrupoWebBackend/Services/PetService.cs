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

        public async Task<IEnumerable<Pet>> ListAsync()
        {
            return await _petRepository.ListAsync();
        }
        public async Task<PetResponse> FindAsync(int id)
        {
            return new PetResponse(await _petRepository.FindAsync(id));
        }
        public async Task<PetResponse> SaveAsync(Pet pet)
        {
            await _petRepository.AddAsync(pet);
            return new PetResponse(pet);
        }

        Task<PetResponse> IPetService.DeleteAsync(Pet pet)
        {
            throw new System.NotImplementedException();
        }


        
    }
}