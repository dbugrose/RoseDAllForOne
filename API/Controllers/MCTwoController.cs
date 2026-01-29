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
    public class MCTwoController : ControllerBase
    {
        private readonly MCTwoServices _mcTwoServices;
        public MCTwoController(MCTwoServices mcTwoServices)
        {
            _mcTwoServices = mcTwoServices;
        }

    [HttpGet("EnterNameAndWakeTime/{name}/{wakeTime}")]
    public string NameAndWakeTime(string name, int wakeTime)
        {
           return _mcTwoServices.NameAndWakeTime(name, wakeTime);
        }
    }
}