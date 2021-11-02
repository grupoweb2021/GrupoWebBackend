using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainAdoptionsRequests.Models;
using GrupoWebBackend.DomainAdoptionsRequests.Repositories;
using GrupoWebBackend.DomainAdoptionsRequests.Services;
using GrupoWebBackend.DomainPets.Repositories;
using GrupoWebBackend.Persistence.Repositories;
using GrupoWebBackend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using GrupoWebBackend.DomainAdoptionsRequests.Services.Communications;

namespace GrupoWebBackend.Services
{
    public class AdoptionsRequestsService:IAdoptionsRequestsService
    {
        private readonly IAdoptionsRequestsRepository _requestsAdoptionsRepository;

        private readonly IUnitOfWork _unitOfWork;

        public AdoptionsRequestsService(IAdoptionsRequestsRepository adoptionsRequestsRepository,
            IUnitOfWork unitOfWork)
        {
            _requestsAdoptionsRepository = adoptionsRequestsRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<AdoptionsRequests>> ListAdoptionsRequestsAsync()
        {
            return await _requestsAdoptionsRepository.ListAdoptionsRequestsAsync();
        }

     /*   public async Task<IEnumerable<AdoptionsRequests>> ListByUserId(int userId)
        {
            return await _requestsAdoptionsRepository.FindByUserId(userId);
        }
*/
      public async Task<AdoptionsRequestsResponse> SaveAsync(AdoptionsRequests adoptionsRequest)
      {
          await _requestsAdoptionsRepository.AddAsync(adoptionsRequest);
          await _unitOfWork.CompleteAsync();
          return new AdoptionsRequestsResponse(adoptionsRequest);
      }

      public async Task<AdoptionsRequestsResponse> UpdateAsync(int id, AdoptionsRequests adoptionsRequest)
      {
          var existingAdoptionsRequests = await _requestsAdoptionsRepository.FindByIdAsync(id);
          if (existingAdoptionsRequests == null)
              return new AdoptionsRequestsResponse("Adoptions Requests not Found");
          existingAdoptionsRequests.Message = adoptionsRequest.Message;
          existingAdoptionsRequests.Status = adoptionsRequest.Status;
          
          _requestsAdoptionsRepository.Update(existingAdoptionsRequests);
          return new AdoptionsRequestsResponse(existingAdoptionsRequests);
      }

      public async Task<AdoptionsRequestsResponse> DeleteAsync(int id)
      {
          var existingAdoptionsRequests = await _requestsAdoptionsRepository.FindByIdAsync(id);

          if (existingAdoptionsRequests == null)
              return new AdoptionsRequestsResponse("Adoptions Requests not found");
          _requestsAdoptionsRepository.Remove(existingAdoptionsRequests);
          return new AdoptionsRequestsResponse(existingAdoptionsRequests);
      }
    }
}