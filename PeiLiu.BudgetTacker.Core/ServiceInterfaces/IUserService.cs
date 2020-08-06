using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PeiLiu.BudgetTacker.Core.Entities;
using PeiLiu.BudgetTacker.Core.Models.Request;
using PeiLiu.BudgetTacker.Core.Models.Response;

namespace PeiLiu.BudgetTacker.Core.ServiceInterfaces
{
    public interface IUserService
    {
        Task<IEnumerable<Users>> GetAllUsers();
        Task<UserResponseModel> AddUser(UserRequestModel requestModel);
        Task DeleteUser(UserRequestModel requestModel);

        Task<Users> GetUserById(int id);
    }
}
