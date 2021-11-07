﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainPublications.Models;
using GrupoWebBackend.DomainPublications.Services;
using GrupoWebBackend.Extensions;
using GrupoWebBackend.Resources;
using Microsoft.AspNetCore.Mvc;

namespace GrupoWebBackend.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class PublicationsController:ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPublicationService _publicationService;
        public PublicationsController(IMapper mapper, IPublicationService publicationService)
        {
            _mapper = mapper;
            _publicationService = publicationService;
        }

        [HttpGet]
        public async Task<IEnumerable<PublicationResource>> GetAllPublications()
        {
            var _publications = await _publicationService.ListPublicationAsync();
            var resources = _mapper.Map<IEnumerable<Publication>, IEnumerable<PublicationResource>>(_publications);
            return resources;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SavePublicationResource resource)
        {
            if (!ModelState.IsValid)
            
                return BadRequest(ModelState.GetErrorMessages());
          
            var publication = _mapper.Map<SavePublicationResource, Publication>(resource);
            var result = await _publicationService.SaveAsync(publication);

            if (!result.Success)
                return BadRequest(result.Message);


            var publicationResource = _mapper.Map<Publication, PublicationResource>(result.Resource);
            return Ok(publicationResource);
        }
        [HttpPut (template:"{id}")]
        public async Task<IActionResult> PutAsync (int id, [FromBody] SavePublicationResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var publication = _mapper.Map<SavePublicationResource, Publication>(resource);
            var result = await _publicationService.UpdateAsync(id, publication);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = _mapper.Map<Publication, PublicationResource>(result.Resource);

            return Ok(categoryResource);
            
        }
        [HttpDelete(template:"{id}")]
        public async Task<IActionResult>DeleteAsync(int id)
        {
            var result = await _publicationService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);
            var publicationResource = _mapper.Map<Publication, PublicationResource>(result.Resource);
            return Ok(publicationResource);
        }
    }
}