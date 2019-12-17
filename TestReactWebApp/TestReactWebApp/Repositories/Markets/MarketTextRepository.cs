using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestReactWebApp.Extenstions;
using TestReactWebApp.Models;

namespace TestReactWebApp.Repositories
{
    public class MarketTextRepository : IMarketRepository
    {
        public IEnumerable<Market> GetMarkets()
        {
            var jsontext = File.ReadAllText(@"C:\Users\User\Desktop\markets.json");
            var markets = JsonConvert.DeserializeObject<IList<Market>>(jsontext, new JsonSerializerSettings() { ContractResolver = new JsonIgnoreAttributeIgnorerContractResolver() });
            return markets;
        }
    }
}
