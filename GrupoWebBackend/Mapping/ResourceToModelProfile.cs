using AutoMapper;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.Resources;

namespace GrupoWebBackend.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SavePetResource, Pet>();
        }
    }
}