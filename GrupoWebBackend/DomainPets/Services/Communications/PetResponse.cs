using GrupoWebBackend.DomainAdvertisements.Services.Communications;
using GrupoWebBackend.DomainPets.Models;

namespace GrupoWebBackend.DomainPets.Services.Communications
{
    public class PetResponse: BaseResponse<Pet>
    {
        public PetResponse(string message) : base(message)
        {
        }

        public PetResponse(Pet resource) : base(resource)
        {
        }
    }
}