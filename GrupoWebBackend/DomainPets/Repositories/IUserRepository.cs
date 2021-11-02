using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;

namespace GrupoWebBackend.DomainPets.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User> FindByIdAsync(int id);
        Task<IEnumerable<User>> ListAsync();
    }
}