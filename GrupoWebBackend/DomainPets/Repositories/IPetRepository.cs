using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Services.Communications;
using GrupoWebBackend.DomainPublications.Models;

namespace GrupoWebBackend.DomainPets.Repositories
{
    public interface IPetRepository
    { 
        Task<IEnumerable<Pet>> ListAsync();
        Task AddAsync(Pet pet);
        Task<PetResponse> DeleteAsync(Pet pet);
        Task<Pet> FindAsync(int id);
    }
}