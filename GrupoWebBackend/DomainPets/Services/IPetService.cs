using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Services.Communications;

namespace GrupoWebBackend.DomainPets.Services
{
    public interface IPetService
    {
        Task<IEnumerable<Pet>> ListAsync();
        Task<Pet> FindAsync(int id);
        Task<SavePetResponse> AddAsync(Pet publication);

    }
    
}