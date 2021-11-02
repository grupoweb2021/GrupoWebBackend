using AutoMapper;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.Resources;

namespace GrupoWebBackend.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Pet, PetResource>();
        }
    }
}