using CoinMarketWrapper.BussinessLogic.CoinMarket;
using CoinMarketWrapper.Model;
using CoinMarketWrapper.NetworkClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinMarketWrapper.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoinMarketController : ControllerBase
    {
        private ICoinMarketService _coinMarketService;

        public CoinMarketController(ICoinMarketService coinmarketService )
        {
            _coinMarketService = coinmarketService;
        }

        [HttpGet("latest")]
        public async Task<IActionResult> GetLatestCoinPrice()
        {
           
            return Ok(await _coinMarketService.GetCoinInfoList());
        }
    }
}
