using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Services;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MCElevenController : ControllerBase
    {
        private readonly MCElevenServices _mcElevenServices;
        public MCElevenController(MCElevenServices mcElevenServices)
        {
            _mcElevenServices = mcElevenServices;
        }

        [HttpGet("GreaterLess/{num1}/{num2}")]
        public string GreaterLess(int num1, int num2){
          return  _mcElevenServices.GreaterLess(num1, num2);
        }
    }
}