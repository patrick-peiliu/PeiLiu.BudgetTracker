using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeiLiu.BudgetTacker.Core.Models.Request;
using PeiLiu.BudgetTacker.Core.ServiceInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeiLiu.BudgetTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeService _incomeService;

        public IncomeController(IIncomeService incomeService)
        {
            _incomeService = incomeService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Incomes(int id)
        {
            var incomes = await _incomeService.GetIncomesByUserId(id);

            return Ok(incomes);
        }

        [Route("add")]
        [HttpPost]
        public async Task<IActionResult> Purchase([FromBody] IncomeRequestModel incomeRequestModel)
        {
            await _incomeService.AddIncome(incomeRequestModel);
            return Ok();
        }
    }
}
