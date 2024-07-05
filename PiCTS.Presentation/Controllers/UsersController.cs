using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects;
using PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.UserDTOs;
using PiCTS.Entities.DataTransferObjects.UserDTOs.RequestDTOs;
using PiCTS.Entities.Models;
using PiCTS.Presentation.ActionFilters;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public UsersController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Kullanicilari Gorme")]
        [HttpGet("GetAllUserAsync")]
        public async Task<IActionResult> GetAllUserAsync()
        {
            var users = await _manager.UserService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("GetAllLimitedUsersAsync")]
        public async Task<IActionResult> GetAllLimitedUsersAsync()
        {
            var users = await _manager.UserService.GetAllLimitedUsersAsync();
            return Ok(users);
        }

        [Authorize(Roles = "Kullanicilari Gorme")]
        [HttpPost("GetOneUserByUserNameAsync")]
        public async Task<IActionResult> GetOneUserByUserNameAsync([FromBody]UserNameDTO userNameDTO)
        {
            var user = await _manager.UserService.GetOneUserByUserNameAsync(userNameDTO);
            return Ok(user);
        }

        [HttpPost("GetOneUserByNameForSettingsAsync")]
        public async Task<IActionResult> GetOneUserByNameForSettingsAsync([FromBody]UserNameDTO userNameDTO)
        {
            var user = await _manager.UserService.GetOneUserByNameForSettingsAsync(userNameDTO);
            return Ok(user);
        }

        [Authorize(Roles = "Kullanicilari Gorme")]
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetOneUserByIdAsync([FromRoute(Name = "id")]Guid id)
        {
            var user = await _manager.UserService.GetOneUserByIdAsync(id);
            return Ok(user);
        }

        [Authorize(Roles = "Kullanici Oluşturma")]
        [HttpPost]
        public async Task<IActionResult> CreateOneUser([FromBody]UserForRegistrationDTO userForRegistrationDTO)
        {
            var result = await _manager.UserService.CreateOneUserAsycn(userForRegistrationDTO);
            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.TryAddModelError(err.Code, err.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

        [Authorize(Roles = "Kullanici Silme")]
        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteUser([FromRoute(Name = "id")]Guid id)
        {
            await _manager.UserService.DeleteOneUserAsync(id);
            return NoContent();
        }

        [Authorize(Roles = "Kullanici Güncelleme")]
        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateOneUser([FromRoute(Name = "id")]Guid id, [FromBody] UserForUpdateDTO userForUpdateDTO)
        {
            await _manager.UserService.UpdateOneUserAsync(id, userForUpdateDTO);
            return NoContent();
        }

        [HttpPut("UpdateOneUserForSettings/{id:guid}")]
        public async Task<IActionResult> UpdateOneUserForSettings([FromRoute(Name = "id")] Guid id,[FromBody] UserForUpdateDTO userForUpdateDTO)
        {
            await _manager.UserService.UpdateOneUserAsync(id, userForUpdateDTO);
            return NoContent();
        }

        [Authorize(Roles = "Kullanici Güncelleme")]
        [HttpPut("UpdateOneUserStatusAsync")]
        public async Task<IActionResult> UpdateOneUserStatusAsync([FromBody] UserStatusUpdateDTO userStatusUpdateDTO)
        {
            await _manager.UserService.UpdateOneUserStatusAsync(userStatusUpdateDTO);
            return NoContent();
        }
    }
}
