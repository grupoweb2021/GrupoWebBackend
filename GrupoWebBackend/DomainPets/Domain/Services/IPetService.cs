using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Domain.Models;
using GrupoWebBackend.DomainPets.Domain.Services.Communications;

namespace GrupoWebBackend.DomainPets.Domain.Services
{
    public interface IPetService
    {
        Task<IEnumerable<Pet>> ListAsync();
        Task<Pet> FindAsync(int id);
        Task<SavePetResponse> AddAsync(Pet publication);
        Task<PetResponse> UpdateAsync(Pet pet, int id);
    }
    
}