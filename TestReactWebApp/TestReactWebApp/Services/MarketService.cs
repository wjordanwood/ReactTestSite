using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestReactWebApp.Models;
using TestReactWebApp.Repositories;

namespace TestReactWebApp.Services
{
    public class MarketService
    {
        public IMarketRepository MarketRepository = new MarketTextRepository();

        public IEnumerable<Market> GetMarkets()
        {
            return MarketRepository.GetMarkets();
        }
    }
}
