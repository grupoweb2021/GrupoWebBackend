using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Services.Communications;

namespace GrupoWebBackend.DomainPets.Services
{
    public interface IPetService
    {
        Task<IEnumerable<Pet>> ListPetAsync();
        Task<PetResponse> SaveAsync(Pet publication);

    }
    
}