using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestReactWebApp.Models;

namespace TestReactWebApp.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : BaseController
    {
        [HttpPost("[action]")]
        public JsonResult Login([FromBody] LoginForm form)
        {
            User user = null;
            try
            {
                user = UserService.AuthenticateCustomer(form.Username, form.Password);
                if (user != null)
                {
                    return new JsonResult(new
                    {
                        success = true,
                        message = $"Welcome {user.FirstName} {user.LastName}"
                    });
                }
            }
            catch (Exception ex)
            {
                // somethig went wrong and user cannot be authenticated
            }

            return new JsonResult(new
            {
                success = false,
                message = "We could not log you in. Sorry!"
            });
        }
    }
}
