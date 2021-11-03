using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Repositories;
using GrupoWebBackend.DomainPets.Services;
using GrupoWebBackend.DomainPets.Services.Communications;

namespace GrupoWebBackend.Services
{
    public class PetService: IPetService
    {
        private readonly IPetRepository _petRepository;
        private readonly IUnitOfWork _unitOfWork;
        
        public PetService(IPetRepository petRepository, IUnitOfWork unitOfWork)
        {
            _petRepository = petRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Pet>> ListAsync()
        {
            return await _petRepository.ListAsync();
        }



        public async Task<Pet> FindAsync(int id)
        {
            return await _petRepository.FindAsync(id);
        }
        
        public async Task<SavePetResponse> AddAsync(Pet pet)
        {
            try
            {
                await _petRepository.AddAsync(pet);
                await _unitOfWork.CompleteAsync();
                return new SavePetResponse(pet);
            }
            catch (Exception e)
            {
                return new SavePetResponse($"An error occurred while saving Category: {e.Message}");
            }
        }

        public async Task<PetResponse> UpdateAsync(Pet pet, int id)
        {
            var existingPet = await _petRepository.FindAsync(id);
            if (existingPet == null)
                return new PetResponse("Pet not found");
            existingPet.Age = pet.Age;
            existingPet.Attention = pet.Attention;
            existingPet.Name = pet.Name;
            existingPet.Race = pet.Race;
            existingPet.Type = pet.Type;
            existingPet.IsAdopted = pet.IsAdopted;

            try
            {
                _petRepository.UpdateAsync(existingPet);
                await _unitOfWork.CompleteAsync();
                return new PetResponse(existingPet);
            }
            catch (Exception e)
            {
                return new PetResponse($"An error occurred while saving Category: {e.Message}");
            }
        }
    }
}

