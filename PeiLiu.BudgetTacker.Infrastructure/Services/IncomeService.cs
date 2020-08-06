using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PeiLiu.BudgetTacker.Core.Entities;
using PeiLiu.BudgetTacker.Core.Models.Request;
using PeiLiu.BudgetTacker.Core.RepositoryInterfaces;
using PeiLiu.BudgetTacker.Core.ServiceInterfaces;

namespace PeiLiu.BudgetTacker.Infrastructure.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly IIncomeRepository _incomeRepository;
        public IncomeService(IIncomeRepository incomeRepository)
        {
            _incomeRepository = incomeRepository;
        }

        public async Task<Incomes> AddIncome(IncomeRequestModel incomeRequestModel)
        {
            var income = new Incomes
            {
                UsersId = incomeRequestModel.UserId,
                Amount = incomeRequestModel.Amount.Value,
                Description = incomeRequestModel.Description
            };

            return await _incomeRepository.AddAsync(income);
        }

        public async Task<IEnumerable<Incomes>> GetIncomesByUserId(int id)
        {
            return await _incomeRepository.GetIncomesByUserId(id);
        }
    }
}
