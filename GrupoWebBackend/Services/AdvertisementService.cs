﻿
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainAdvertisements.Models;
using GrupoWebBackend.DomainAdvertisements.Repositories;
using GrupoWebBackend.DomainAdvertisements.Services;
using GrupoWebBackend.DomainAdvertisements.Services.Communications;
using GrupoWebBackend.DomainPets.Repositories;

namespace GrupoWebBackend.Services
{
    public class AdvertisementService: IAdvertisementService
    {
        private IAdvertisementRepository _advertisementRepository;
        private IUserRepository _userRepository;
       
        public AdvertisementService(IAdvertisementRepository advertisementRepository,IUserRepository userRepository)
        {
            _advertisementRepository = advertisementRepository;
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<Advertisement>> ListAdvertisementAsync()
        {
            return await _advertisementRepository.ListAdvertisementAsync();
        }

        public async Task<IEnumerable<Advertisement>> ListByUserId(int userId)
        {
            return await _advertisementRepository.FindByUserId(userId);
        }

        public async Task<AdvertisementResponse> SaveAsync(Advertisement advertisement)
        {
            var existingUser = _userRepository.FindByIdAsync(advertisement.UserId);
            if (existingUser == null)
                return new AdvertisementResponse("invalid user");
            var existingAdvertisement = await _advertisementRepository.FindByTitleAsync(advertisement.Title);
            if (existingAdvertisement != null)
                return new AdvertisementResponse("Advertisement title already exists");
            try
            {
                await _advertisementRepository.AddAsync(advertisement);
                return new AdvertisementResponse(advertisement);
            }
            catch (Exception e)
            {
                return new AdvertisementResponse($"An error occurred while saving the advertisement: {e.Message}");
            }
        }

        public async Task<AdvertisementResponse> UpdateAsync(int id, Advertisement advertisement)
        {
          
            var existingAdvertisement = await _advertisementRepository.FindByIdAsync(id);
            if (existingAdvertisement == null)
                return new AdvertisementResponse("Advertisement not found");

            var existingUser = _userRepository.FindByIdAsync(advertisement.UserId);
            if (existingUser == null)
                return new AdvertisementResponse("Invalid user");
            
            var existingAdvertisementWithTitle = await _advertisementRepository.FindByTitleAsync(advertisement.Title);
            if (existingAdvertisementWithTitle != null && existingAdvertisementWithTitle.Id!=existingAdvertisement.Id)
                return new AdvertisementResponse("Advertisement title already exists");

            existingAdvertisement.Description = advertisement.Description;
            existingAdvertisement.Discount = advertisement.Discount;
            existingAdvertisement.Promoted = advertisement.Promoted;
            existingAdvertisement.Title = advertisement.Title;
            existingAdvertisement.DateTime = advertisement.DateTime;
            existingAdvertisement.UrlToImage = advertisement.UrlToImage;
            try
            {
                _advertisementRepository.Update(existingAdvertisement);
                return new AdvertisementResponse(existingAdvertisement);
            }
            catch(Exception e)
            {
                return new AdvertisementResponse($"An error occurred while updating the advertisement: {e.Message}");
            }
        }

        public async Task<AdvertisementResponse> DeleteAsync(int id)
        {
            var existingAdvertisement = await _advertisementRepository.FindByIdAsync(id);
            if (existingAdvertisement == null)
                return new AdvertisementResponse("Advertisement not found");
            try
            {
                _advertisementRepository.Remove(existingAdvertisement);
                return new AdvertisementResponse(existingAdvertisement);

            }
            catch (Exception e)
            {
                return new AdvertisementResponse($"An error occurred while deleting the advertisement: {e.Message}");
            }
        }
    }
}