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
    public class MCFiveController : ControllerBase
    {
        private readonly MCFiveServices _mcFiveServices;
        public MCFiveController(MCFiveServices mcFiveServices)
        {
            _mcFiveServices = mcFiveServices;
        }
    [HttpGet("EnterANumber/{num3}")]
    public string OddOrEven(int num3)
        {
            return _mcFiveServices.OddOrEven(num3);
        }
    }
}