using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Services.Communications;
using GrupoWebBackend.Resources;

namespace GrupoWebBackend.DomainPets.Services
{
    public interface IUserService
    {
        Task<UserResponse> AddAsync(User user);
        Task<IEnumerable<User>> ListAsync();
    }
}