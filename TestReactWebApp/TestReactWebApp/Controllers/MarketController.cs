using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestReactWebApp.Controllers
{
    [Route("api/[controller]")]
    public class MarketController : BaseController
    {
        [HttpGet("[action]")]
        public JsonResult GetMarkets()
        {
            var markets = MarketService.GetMarkets();

            return new JsonResult(new
            {
                success = true,
                markets = markets
            });
        }
    }
}