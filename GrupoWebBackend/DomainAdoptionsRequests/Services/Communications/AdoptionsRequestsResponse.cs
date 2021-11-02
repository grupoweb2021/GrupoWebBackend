using GrupoWebBackend.DomainAdoptionsRequests.Models;
using GrupoWebBackend.DomainAdvertisements.Services.Communications;
namespace GrupoWebBackend.DomainAdoptionsRequests.Services.Communications
{
    public class AdoptionsRequestsResponse:BaseResponse<AdoptionsRequests>
    {
        public AdoptionsRequestsResponse(string message) : base(message)
        {
            
        }

        public AdoptionsRequestsResponse(AdoptionsRequests resource) : base(resource)
        {
            
        }
    }
}