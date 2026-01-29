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
    public class MCFourController : ControllerBase
    {
        private readonly MCFourServices _mcFourServices;
        public MCFourController(MCFourServices mcFourServices)
        {
            _mcFourServices = mcFourServices;
        }
    
    [HttpGet("MadLib/{adjective}/{mythicalcreature}/{items}/{place}/{food}")]
            public string MadLib(string adjective, string mythicalcreature, string items, string place, string food)
        {
            return _mcFourServices.MadLib(adjective, mythicalcreature, items, place, food);
        }
    }
}