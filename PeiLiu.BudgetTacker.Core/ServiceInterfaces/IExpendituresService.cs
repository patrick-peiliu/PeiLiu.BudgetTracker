using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PeiLiu.BudgetTacker.Core.Entities;
using PeiLiu.BudgetTacker.Core.Models.Request;

namespace PeiLiu.BudgetTacker.Core.ServiceInterfaces
{
    public interface IExpendituresService
    {
        Task<IEnumerable<Expenditures>> GetExpendituresByUserId(int id);
        Task<Expenditures> AddExpenditure(ExpenditureRequestModel expenditureRequestModel);
    }
}
