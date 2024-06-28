using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.RequestDTOs;
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
    [Route("api/authentication")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public AuthenticationController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody]UserForRegistrationDTO userForRegistrationDTO)
        {
            var result = await _manager.AuthenticationService.RegisterUser(userForRegistrationDTO);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDTO userForAuthenticationDTO)
        {
            if (!await _manager.AuthenticationService.ValidateUser(userForAuthenticationDTO))
            {
                return Unauthorized();
            }
            var tokenDto = await _manager.AuthenticationService.CreateToken(populateExp: true);
            return Ok(tokenDto);
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] TokenDTO tokenDto)
        {
            var tokenDtoToReturn = await _manager.AuthenticationService.RefreshToken(tokenDto);
            return Ok(tokenDtoToReturn);
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout([FromBody]string userName)
        {
            await _manager.AuthenticationService.Logout(userName);
            return Ok();
        }
    }
}
