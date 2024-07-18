using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PiCTS.Entities.DataTransferObjects;
using PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.UserDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.UserDTOs.ResponseDTOs;
using PiCTS.Entities.Exceptions;
using PiCTS.Entities.Models;
using PiCTS.Repositories.Contract;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Concrete
{
    public class UserManager : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public UserManager(UserManager<User> userManager, IMapper mapper, IRepositoryManager manager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _manager = manager;
        }

        public async Task<IdentityResult> CreateOneUserAsycn(UserForRegistrationDTO userForRegistrationDTO)
        {
            var user = _mapper.Map<User>(userForRegistrationDTO);
            user.CreatedDate = DateTime.Now;
            user.UpdatedDate = user.UpdatedDate;
            user.DeletedDate = user.DeletedDate;
            var result = await _userManager.CreateAsync(user, userForRegistrationDTO.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRolesAsync(user, userForRegistrationDTO.Roles);

            }
            await _manager.SaveChanges();
            return result;
        }

        public async Task DeleteOneUserAsync(Guid id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == Convert.ToString(id));
            if (user == null)
            {
                throw new UserNotFoundException(id);
            }

            await _userManager.DeleteAsync(user);
            await _manager.SaveChanges();
        }

        public async Task<IEnumerable<UserLimitedResponseDTO>> GetAllLimitedUsersAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            foreach (var user in users)
            {
                user.IsDeleted = !user.IsDeleted;
            }
            var returnedUsers = _mapper.Map<IEnumerable<UserLimitedResponseDTO>>(users);
            return returnedUsers;
        }

        public async Task<IEnumerable<UserResponseDTO>> GetAllUsersAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            foreach (var user in users)
            {
                user.IsDeleted = !user.IsDeleted;
            }
            var returnedUsers = _mapper.Map<IEnumerable<UserResponseDTO>>(users);
            return returnedUsers;
        }

        public async Task<User> GetOneUserByIdAsync(Guid id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == Convert.ToString(id));
            if(user == null)
            {
                throw new UserNotFoundException(id);
            }
            return user;
        }

        public async Task<UserSeettingsResponseDTO> GetOneUserByNameForSettingsAsync(UserNameDTO userNameDTO)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.UserName == userNameDTO.UserName);
            if(user == null)
            {
                throw new UserNotFounByNameException(userNameDTO.UserName);
            }
            return _mapper.Map<UserSeettingsResponseDTO>(user);
        }

        public async Task<UserResponseDTO> GetOneUserByUserNameAsync(UserNameDTO userNameDTO)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.UserName == userNameDTO.UserName);

            if(user == null)
            {
                throw new UserNotFounByNameException(user.UserName);
            }
            return _mapper.Map<UserResponseDTO>(user);
        }

        public async Task UpdateOneUserAsync(Guid id, UserForUpdateDTO userForUpdateDTO)
        {
            var entity = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == Convert.ToString(id));
            if(entity == null)
            {
                throw new UserNotFoundException(id);
            }
            if(userForUpdateDTO == null)
            {
                throw new ArgumentNullException(nameof(userForUpdateDTO));
            }


            entity.FirstName = userForUpdateDTO.FirstName;
            entity.LastName = userForUpdateDTO.LastName;
            entity.UserName = userForUpdateDTO.UserName;
            entity.CreatedDate = entity.CreatedDate;
            entity.UpdatedDate = DateTime.Now;
            entity.DeletedDate = entity.DeletedDate;

            if (!string.IsNullOrEmpty(userForUpdateDTO.Password))
            {
                var newPasswordHash = _userManager.PasswordHasher.HashPassword(entity, userForUpdateDTO.Password);
                entity.PasswordHash = newPasswordHash;
            }

            await _userManager.UpdateAsync(entity);
            await _manager.SaveChanges();

        }

        public async Task UpdateOneUserStatusAsync(UserStatusUpdateDTO userStatusUpdateDTO)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == Convert.ToString(userStatusUpdateDTO.Id));
            if(user == null)
            {
                throw new UserNotFoundException(userStatusUpdateDTO.Id);
            }
            if(userStatusUpdateDTO == null)
            {
                throw new ArgumentNullException(nameof(userStatusUpdateDTO));
            }

            user.IsDeleted = !userStatusUpdateDTO.IsDeleted;

            await _userManager.UpdateAsync(user);
            await _manager.SaveChanges();
        }
    }
}
