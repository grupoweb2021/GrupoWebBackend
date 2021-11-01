using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Repositories;
using GrupoWebBackend.DomainPets.Services.Communications;
using GrupoWebBackend.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace GrupoWebBackend.Persistence.Repositories
{
    public class PetRepository: BaseRepository, IPetRepository
    {
        public PetRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Pet>> ListPetAsync()
        {
            return await _context.Pets.ToListAsync();
        }
        

        public async Task AddAsync(Pet pet)
        {
            await _context.Pets.AddAsync(pet);
        }
    }
}