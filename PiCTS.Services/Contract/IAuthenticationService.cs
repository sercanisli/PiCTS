using Microsoft.AspNetCore.Identity;
using PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDTO userForRegistrationDTO);
        Task<bool> ValidateUser(UserForAuthenticationDTO userForAuthenticationDTO);
        Task<TokenResponseDTO> CreateToken(bool populateExp);
        Task<TokenResponseDTO> RefreshToken(TokenDTO tokenDto);
        Task Logout(string username);
    }
}
