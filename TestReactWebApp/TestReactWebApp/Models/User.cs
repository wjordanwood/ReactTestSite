using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestReactWebApp.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int UserID { get; set; }
        public string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
