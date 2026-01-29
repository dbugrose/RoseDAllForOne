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
    public class MCNineController : ControllerBase
    {
        private readonly MCNineServices _mcNineServices;
        public MCNineController(MCNineServices mcNineServices)
        {
            _mcNineServices = mcNineServices;
        }

    [HttpGet("guessANum1to10/{num5}")]
    public string guessANum1to10(int num5)
        {
            return _mcNineServices.guessANumber1to10(num5);
        }
    [HttpGet("guessANum1to50/{num6}")]
    public string guessANum1to50(int num6)
        {
            return _mcNineServices.guessANumber1to50(num6);
        }
    [HttpGet("guessANum1to100/{num7}")]
    public string guessANum1to100(int num7)
        {
            return _mcNineServices.guessANumber1to100(num7);
        }
    }
}