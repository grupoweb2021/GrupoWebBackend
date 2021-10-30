using GrupoWebBackend.DomainAdvertisements.Models;

namespace GrupoWebBackend.DomainAdvertisements.Services.Communications
{
    public class AdvertisementResponse:BaseResponse<Advertisement>
    {
        public AdvertisementResponse(string message): base(message)
        {

        }
        public AdvertisementResponse(Advertisement resource): base(resource)
        {

        }
    }
}