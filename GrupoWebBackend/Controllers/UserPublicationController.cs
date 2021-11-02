using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GrupoWebBackend.DomainPublications.Models;
using GrupoWebBackend.DomainPublications.Services;
using GrupoWebBackend.Resources;
using Microsoft.AspNetCore.Mvc;

namespace GrupoWebBackend.Controllers
{
    [ApiController]
    [Route("/api/v1/Users/{userId}/Publications")]
    public class UserPublicationController
    {
        private readonly IPublicationService _publicationService;
        private readonly IMapper _mapper;

        public UserPublicationController(IPublicationService publicationService,IMapper mapper)
        {
            _publicationService = publicationService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<PublicationResource>> GetAllByUserIdAsync(int userId)
        {
            var publications= await _publicationService.ListByUserId(userId);
            var resources = _mapper.Map<IEnumerable<Publication>, IEnumerable<PublicationResource>>(publications);
            return resources;
        }
    }
}