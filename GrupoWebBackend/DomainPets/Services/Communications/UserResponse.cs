using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainAdvertisements.Services.Communications;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.Resources;

namespace GrupoWebBackend.DomainPets.Services.Communications
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