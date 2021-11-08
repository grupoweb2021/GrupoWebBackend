using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Domain.Models;
using GrupoWebBackend.DomainUsers.Domain.Models;

namespace GrupoWebBackend.DomainUsers.Domain.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User> FindByIdAsync(int id);
        Task<IEnumerable<User>> ListAsync();
    }
}