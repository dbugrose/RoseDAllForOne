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
    public class MCEightController : ControllerBase
    {
        private readonly MCEightServices _mcEightServices;
        public MCEightController(MCEightServices mcEightServices)
        {
            _mcEightServices = mcEightServices;
        }

    [HttpGet("RandomAnswer/{question}")]

    public string RandomAnswer(string question)
        {
            return _mcEightServices.MagicEightBall(question);
        }
    }
}