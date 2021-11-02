using AutoMapper;
using GrupoWebBackend.DomainAdoptionsRequests.Models;
using GrupoWebBackend.DomainAdoptionsRequests.Services.Communications;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPublications.Models;
using GrupoWebBackend.Resources;

namespace GrupoWebBackend.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Pet, PetResource>();
            CreateMap<Advertisement, AdvertisementResource>();
            CreateMap<Publication, PublicationResource>();
            CreateMap<AdoptionsRequests, AdoptionsRequestsResource>();
        }
    }
}