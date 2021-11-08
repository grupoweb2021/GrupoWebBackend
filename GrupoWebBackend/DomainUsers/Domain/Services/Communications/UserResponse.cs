using GrupoWebBackend.DomainAdvertisements.Domain.Models;
using GrupoWebBackend.DomainAdvertisements.Domain.Services.Communications;
using GrupoWebBackend.DomainPets.Domain.Models;
using GrupoWebBackend.DomainUsers.Domain.Models;
using GrupoWebBackend.DomainUsers.Resources;

namespace GrupoWebBackend.DomainUsers.Domain.Services.Communications
{
    public class UserResponse:BaseResponse<User>
    {
   
        public UserResponse(string message) : base( message)
        {
            
        }
        public UserResponse(User user) : base(user)
        {
            
        }
    }
}