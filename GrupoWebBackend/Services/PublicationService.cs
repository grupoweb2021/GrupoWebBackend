using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Repositories;
using GrupoWebBackend.DomainPublications.Models;
using GrupoWebBackend.DomainPublications.Repositories;
using GrupoWebBackend.DomainPublications.Services;
using GrupoWebBackend.DomainPublications.Services.Communications;

namespace GrupoWebBackend.Services
{
    public class PublicationService:IPublicationService
    {
        private readonly IPublicationRepository _publicationRepository;
        //private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PublicationService(IPublicationRepository publicationRepository,IUnitOfWork unitOfWork)
        {
            _publicationRepository = publicationRepository;
            _unitOfWork = unitOfWork;
            //_userRepository = userRepository;
        }
        public async Task<IEnumerable<Publication>> ListPublicationAsync()
        {
            return await _publicationRepository.ListPublicationsAsync();
        }
        public async Task<IEnumerable<Publication>> ListByUserId(int userId)
        {
            return await _publicationRepository.FindByUserId(userId);
        }

        public async Task<PublicationResponse> SaveAsync(Publication publication)
        { 
            await _publicationRepository.AddAsync(publication);
            await _unitOfWork.CompleteAsync();
            return new PublicationResponse(publication);
        }

        public async Task<PublicationResponse> UpdateAsync(int id, Publication publication)
        {
            var existingPublication = await _publicationRepository.FindByIdAsync(id);

            if (existingPublication == null)
                return new PublicationResponse("Publication not Found");
            existingPublication.Comment = publication.Comment;
            existingPublication.DateTime = publication.DateTime;
            existingPublication.PetId = publication.PetId;
            existingPublication.UserId = publication.UserId;
            _publicationRepository.Update(existingPublication);
            return new PublicationResponse(existingPublication);
        }

        public async Task<PublicationResponse> DeleteAsync(int id)
        {
            var existingPublication = await _publicationRepository.FindByIdAsync(id);

            if (existingPublication == null)
                return new PublicationResponse("Publication not Found");
            _publicationRepository.Remove(existingPublication);
            return new PublicationResponse(existingPublication);
        }
    }
}