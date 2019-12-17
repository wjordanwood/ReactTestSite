using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestReactWebApp.Models
{
    public class Market
    {
        public int Name { get; set; }
        public string Description { get; set; }
        public string CookieValue { get; set; }
        public string CultureCode { get; set; }
        public bool IsDefault { get; set; }
        public List<string> Countries { get; set; }
        public List<object> AvailablePaymentMethods { get; set; }
        public List<object> AvailableLanguages { get; set; }
        public List<object> AvailableAutoOrderFrequencyTypes { get; set; }
        public string MainCountry { get {
                return Countries.FirstOrDefault();
            }
        }
    }
}
