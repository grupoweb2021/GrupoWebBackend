using GrupoWebBackend.DomainAdvertisements.Services.Communications;
using GrupoWebBackend.DomainPublications.Models;

namespace GrupoWebBackend.DomainPublications.Services.Communications
{
    public class PublicationResponse:BaseResponse<Publication>
    {
        public PublicationResponse(string message): base(message)
        {

        }
        public PublicationResponse(Publication resource): base(resource)
        {

        }
    }
}