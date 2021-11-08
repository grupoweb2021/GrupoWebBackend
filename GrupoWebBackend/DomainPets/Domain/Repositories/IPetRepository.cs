using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Domain.Models;
using GrupoWebBackend.DomainPets.Domain.Services.Communications;
using GrupoWebBackend.DomainPublications.Domain.Models;

namespace GrupoWebBackend.DomainPets.Domain.Repositories
{
    public interface IPetRepository
    { 
        Task<IEnumerable<Pet>> ListAsync();
        Task<Pet> FindAsync(int id);
        Task AddAsync(Pet pet);
        void UpdateAsync(Pet pet);
    }
}