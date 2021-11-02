using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GrupoWebBackend.DomainPets.Models;
using GrupoWebBackend.DomainPets.Services;
using GrupoWebBackend.Extensions;
using GrupoWebBackend.Resources;
using Microsoft.AspNetCore.Mvc;

namespace GrupoWebBackend.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class UsersController:ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UsersController(IMapper mapper,IUserService userService )
        {
            _mapper = mapper;
            _userService = userService;

        }
        [HttpGet]
        public async Task<IEnumerable<User>> ListAsync()
        {
            var user = await _userService.ListAsync();
            return user;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveUserResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            
            var user = _mapper.Map<SaveUserResource, User>(resource);
            var result = await _userService.AddAsync(user);
            
            if (!result.Success)
                return BadRequest(result.Message);
            
            var petResource = _mapper.Map<User, SaveUserResource>(result.Resource);
            return Ok(petResource);
        }
    }
}