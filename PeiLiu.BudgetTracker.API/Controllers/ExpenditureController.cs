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
    public class ExpenditureController : Controller
    {
        private readonly IExpendituresService _expendituresService;

        public ExpenditureController(IExpendituresService expendituresService)
        {
            _expendituresService = expendituresService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Expenditures(int id)
        {
            var expenditures = await _expendituresService.GetExpendituresByUserId(id);

            return Ok(expenditures);
        }

        [Route("add")]
        [HttpPost]
        public async Task<IActionResult> Purchase([FromBody] ExpenditureRequestModel expenditureRequestModel)
        {
            await _expendituresService.AddExpenditure(expenditureRequestModel);
            return Ok();
        }
    }
}
