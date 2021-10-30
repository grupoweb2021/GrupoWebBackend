using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;

namespace GrupoWebBackend.DomainPets.Services
{
    public interface IPetService
    {
        Task<IEnumerable<Pet>> ListPetAsync();

    }
    
}