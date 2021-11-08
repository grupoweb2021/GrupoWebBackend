using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Domain.Models;
using GrupoWebBackend.DomainPets.Domain.Services.Communications;
using GrupoWebBackend.DomainUsers.Domain.Models;
using GrupoWebBackend.DomainUsers.Domain.Services.Communications;
using GrupoWebBackend.DomainUsers.Resources;

namespace GrupoWebBackend.DomainUsers.Domain.Services
{
    public interface IUserService
    {
        Task<UserResponse> AddAsync(User user);
        Task<IEnumerable<User>> ListAsync();
    }
}