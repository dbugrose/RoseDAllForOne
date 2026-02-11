using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MCOneController : ControllerBase
    {
        private readonly MCOneServices _mcOneServices;

        public MCOneController(MCOneServices mcOneServices)
        {
            _mcOneServices = mcOneServices;
        }
[HttpGet("SayHello/{name}")]
        public string GreetByName(string name)
        {
           return _mcOneServices.GreetByName(name);
        }
    }
}