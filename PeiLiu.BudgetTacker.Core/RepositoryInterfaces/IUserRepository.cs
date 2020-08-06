using System;
using System.Threading.Tasks;
using PeiLiu.BudgetTacker.Core.Entities;

namespace PeiLiu.BudgetTacker.Core.RepositoryInterfaces
{
    public interface IUserRepository : IAsyncRepository<Users>
    {
        Task<Users> GetUserByName(string name);
    }
}
