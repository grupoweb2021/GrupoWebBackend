using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Repositories;
using GrupoWebBackend.Persistence.Context;

namespace GrupoWebBackend.Persistence.Repositories
{
    public class UserRepository:BaseRepository,IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task<User> FindByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}