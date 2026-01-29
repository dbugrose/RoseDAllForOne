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
    public class MCSixController : ControllerBase
    {
        private readonly MCSixServices _mcSixServices;
        public MCSixController(MCSixServices mcSixServices)
        {
            _mcSixServices = mcSixServices;
        }

    [HttpGet("ReverseAString/{alphanumeric}")]
    public string ReverseAString(string alphanumeric)
        {
            return _mcSixServices.ReverseItAlphanumeric(alphanumeric);
        }
    }
}