using AutoMapper;
using GrupoWebBackend.DomainAdoptionsRequests.Models;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPublications.Models;
using GrupoWebBackend.Resources;

namespace GrupoWebBackend.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SavePetResource, Pet>();
            CreateMap<SaveAdvertisementResource, Advertisement>();
            CreateMap<SaveAdoptionsRequestsResource, AdoptionsRequests>();
            CreateMap<SavePublicationResource, Publication>();
        }
    }
}