using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Domain.Repositories;
using GrupoWebBackend.Shared.Persistence.Context;

namespace GrupoWebBackend.Shared.Persistence.Repositories
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
            await _context.SaveChangesAsync();
        }
    }
}