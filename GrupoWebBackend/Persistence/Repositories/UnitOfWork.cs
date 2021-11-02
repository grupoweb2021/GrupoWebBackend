using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Repositories;
using GrupoWebBackend.Persistence.Context;

namespace GrupoWebBackend.Persistence.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        public readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        
        
        public async Task CompleteAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}