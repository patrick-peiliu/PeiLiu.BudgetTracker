using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PeiLiu.BudgetTacker.Core.Entities;
using PeiLiu.BudgetTacker.Core.Models.Request;
using PeiLiu.BudgetTacker.Core.RepositoryInterfaces;
using PeiLiu.BudgetTacker.Core.ServiceInterfaces;

namespace PeiLiu.BudgetTacker.Infrastructure.Services
{
    public class ExpenditureService : IExpendituresService
    {
        private readonly IExpenditureRepository _expenditureRepository;

        public ExpenditureService(IExpenditureRepository expenditureRepository)
        {
            _expenditureRepository = expenditureRepository;
        }

        public async Task<Expenditures> AddExpenditure(ExpenditureRequestModel expenditureRequestModel)
        {
            var expenditure = new Expenditures
            {
                UsersId = expenditureRequestModel.UserId,
                Amount = expenditureRequestModel.Amount.Value,
                Description = expenditureRequestModel.Description
            };

            return await _expenditureRepository.AddAsync(expenditure);
        }

        public async Task<IEnumerable<Expenditures>> GetExpendituresByUserId(int id)
        {
            return await _expenditureRepository.GetExpendituresByUserId(id);
        }
    }
}
