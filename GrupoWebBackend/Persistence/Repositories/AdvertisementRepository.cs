using System.Collections.Generic;
using System.Linq;
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

        public async Task AddAsync(Advertisement advertisement)
        {
            await _context.Advertisements.AddAsync(advertisement);
        }

        public async Task<Advertisement> FindByIdAsync(int id)
        {
            return await _context.Advertisements.FindAsync(id);
        }
        public async Task<Advertisement> FindByTitleAsync(string title)
        {
            return await _context.Advertisements.Include(p => p.User)
                .FirstOrDefaultAsync(p => p.Title == title);
        }

        public void Update(Advertisement advertisement)
        {
            _context.Advertisements.Update(advertisement);
        }

        public void Remove(Advertisement advertisement)
        {
            _context.Advertisements.Remove(advertisement);
        }

        public async Task<IEnumerable<Advertisement>> FindByUserId(int userId)
        {
            return await _context.Advertisements.Where(p => p.UserId == userId)
                .Include(p => p.User)
                .ToListAsync();

        }
    }
}