using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Services.Communications;

namespace GrupoWebBackend.DomainPets.Services
{
    public interface IPetService
    {
        Task<IEnumerable<Pet>> ListAsync();
        Task<PetResponse> SaveAsync(Pet publication);
        Task<PetResponse> DeleteAsync(Pet pet);
        Task<PetResponse> FindAsync(int id);
    }
    
}