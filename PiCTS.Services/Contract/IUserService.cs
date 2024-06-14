using Microsoft.AspNetCore.Identity;
using PiCTS.Entities.DataTransferObjects;
using PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.UserDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.UserDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponseDTO>> GetAllUsersAsync();
        Task<UserResponseDTO> GetOneUserByUserNameAsync(UserNameDTO userNameDTO);
        Task<UserSeettingsResponseDTO> GetOneUserByNameForSettingsAsync(UserNameDTO userNameDTO);
        Task<User> GetOneUserByIdAsync(Guid id);
        Task<IdentityResult> CreateOneUserAsycn(UserForRegistrationDTO userForRegistrationDTO); 
        Task UpdateOneUserAsync(Guid id, UserForUpdateDTO userForUpdateDTO);
        Task DeleteOneUserAsync(Guid id);
    } 
}
