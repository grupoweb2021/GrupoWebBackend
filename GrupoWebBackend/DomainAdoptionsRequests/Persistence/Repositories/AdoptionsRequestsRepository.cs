using GrupoWebBackend.DomainAdoptionsRequests.Domain.Repositories;
using GrupoWebBackend.Shared.Persistence.Context;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainAdoptionsRequests.Domain.Models;
using GrupoWebBackend.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GrupoWebBackend.DomainAdoptionsRequests.Persistence.Repositories
{
    public class AdoptionsRequestsRepository: BaseRepository,IAdoptionsRequestsRepository
    {
        public AdoptionsRequestsRepository(AppDbContext context) : base(context)
        {
            
        }
        
        public async Task<IEnumerable<AdoptionsRequests>> ListAdoptionsRequestsAsync()
        {
            return await _context.AdoptionsRequests.ToListAsync();
        }

        public async Task AddAsync(AdoptionsRequests adoptionsRequests)
        {
            await _context.AdoptionsRequests.AddAsync(adoptionsRequests);
        }

        public async Task<AdoptionsRequests> FindByIdAsync(int id)
        {
            return await _context.AdoptionsRequests.FindAsync(id);
        }

        public void Update(AdoptionsRequests adoptionsRequests)
        {
            _context.AdoptionsRequests.Update(adoptionsRequests);
        }

        public void Remove(AdoptionsRequests adoptionsRequests)
        {
            _context.AdoptionsRequests.Remove(adoptionsRequests);
        }

    }
}