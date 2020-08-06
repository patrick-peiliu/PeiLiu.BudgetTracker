using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeiLiu.BudgetTacker.Core.Entities;
using PeiLiu.BudgetTacker.Core.Models.Request;
using PeiLiu.BudgetTacker.Core.Models.Response;
using PeiLiu.BudgetTacker.Core.RepositoryInterfaces;
using PeiLiu.BudgetTacker.Core.ServiceInterfaces;

namespace PeiLiu.BudgetTacker.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserResponseModel> AddUser(UserRequestModel requestModel)
        {
            var dbUser = await _userRepository.GetUserByName(requestModel.FullName);

            if(dbUser != null)
            {
                throw new Exception("User already existed");
            }

            var user = new Users
            {
                Email = requestModel.Email,
                Password = requestModel.Password,
                FullName = requestModel.FullName
            };

            var createdUser = await _userRepository.AddAsync(user);

            var response = new UserResponseModel
            {
                Id = createdUser.Id,
                Email = createdUser.Email,
                FullName = createdUser.FullName
            };

            return response;
        }

        public async Task DeleteUser(UserRequestModel requestModel)
        {
            var user = await _userRepository.ListAsync(u => u.FullName == requestModel.FullName
                                                            && u.Email == requestModel.Email);

            await _userRepository.DeleteAsync(user.First());
        }

        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            return await _userRepository.ListAllAsync();
        }
    }
}
