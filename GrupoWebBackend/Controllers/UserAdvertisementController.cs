﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainAdvertisements.Services;
using GrupoWebBackend.Resources;
using Microsoft.AspNetCore.Mvc;

namespace GrupoWebBackend.Controllers
{
    [ApiController]
    [Route("/api/v1/Users/{userId}/Advertisements")]
    public class UserAdvertisementController
    {
        private readonly IAdvertisementService _advertisementService;
        private readonly IMapper _mapper;

        public UserAdvertisementController(IAdvertisementService advertisementService,IMapper mapper)
        {
            _advertisementService = advertisementService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AdvertisementResource>> GetAllByUserIdAsync(int userId)
        {
            var advertisements= await _advertisementService.ListByUserId(userId);
            var resources = _mapper.Map<IEnumerable<Advertisement>, IEnumerable<AdvertisementResource>>(advertisements);
            return resources;
        }
    }
}