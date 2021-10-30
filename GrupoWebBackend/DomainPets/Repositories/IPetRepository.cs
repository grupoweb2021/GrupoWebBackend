using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;

namespace GrupoWebBackend.DomainPets.Repositories
{
    public interface IPetRepository
    { 
        Task<IEnumerable<Pet>> ListPetAsync();

    }
}