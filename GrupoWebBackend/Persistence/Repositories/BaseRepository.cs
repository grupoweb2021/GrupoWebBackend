using GrupoWebBackend.Persistence.Context;

namespace GrupoWebBackend.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;
        
        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}