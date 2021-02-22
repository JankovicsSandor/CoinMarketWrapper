using CoinMarketWrapper.BussinessLogic.Asset;
using CoinMarketWrapper.Model;
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
    public class AssetController : ControllerBase
    {
        private IAssetService _assetLogic;

        public AssetController(IAssetService assetLogic)
        {
            _assetLogic = assetLogic;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAssetById(int id)
        {
            Datum result = await _assetLogic.GetAssetById(id);

            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(new RequestErrorResponseModel()
            {
                Error = "Asset not found"
            });
        }
    }
}
