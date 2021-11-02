using GrupoWebBackend.DomainAdvertisements.Services.Communications;
using GrupoWebBackend.DomainPets.Models;

namespace GrupoWebBackend.DomainPets.Services.Communications
{
    public class SavePetResponse: BaseResponseA
    {

        public Pet Pet { get; private set; }
        public SavePetResponse(Pet pet) : this(true, string.Empty, pet)
        {
        }
        public SavePetResponse(bool succces, string message, Pet pet) : base(succces, message)
        {
            Pet = pet;
        }

        public SavePetResponse(string message) : this(true, message, null)
        {
        }
    }
}