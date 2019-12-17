using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestReactWebApp.Services;

namespace TestReactWebApp.Controllers
{
    public class BaseController : Controller
    {
        public UserService UserService = new UserService();
        public MarketService MarketService = new MarketService();
    }
}
