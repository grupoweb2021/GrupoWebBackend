using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainAdvertisements.Repositories;
using GrupoWebBackend.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace GrupoWebBackend.Persistence.Repositories
{
    public class AdvertisementRepository:BaseRepository,IAdvertisementRepository
    {
        public AdvertisementRepository(AppDbContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<Advertisement>> ListAdvertisementAsync()
        {
            //USING framework net
            
            return await _context.Advertisements.ToListAsync();
        }
    }
}