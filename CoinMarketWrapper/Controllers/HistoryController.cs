using CoinMarketWrapper.BussinessLogic.History;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinMarketWrapper.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HistoryController : Controller
    {
        private ITransactionHistoryService _historyService;

        public HistoryController(ITransactionHistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetHistoryList()
        {

            //TODO remove harcode
            return Ok(_historyService.GetTransactionHistory("userId"));
        }
    }
}
