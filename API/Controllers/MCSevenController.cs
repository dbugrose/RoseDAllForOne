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
    public class MCSevenController : ControllerBase
    {
        private readonly MCSevenServices _mcSevenServices;
        public MCSevenController(MCSevenServices mcSevenServices)
        {
            _mcSevenServices = mcSevenServices;
        }

        [HttpGet("ReverseItNumeric/{num4}")]
        public string ReverseItNumeric(int num4)
        {
            return _mcSevenServices.ReverseItNumeric(num4);
        }
    }
}