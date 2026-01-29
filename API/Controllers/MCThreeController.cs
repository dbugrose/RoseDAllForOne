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
    public class MCThreeController : ControllerBase
    {
        private readonly MCThreeServices _mcThreeServices;
        public MCThreeController(MCThreeServices mCThreeServices)
        {
            _mcThreeServices = mCThreeServices;
        }

    [HttpGet("EnterTwoNumbers/{num1}/{num2}")]

    public string AddTwoNumbers(int num1, int num2)
        {
            return _mcThreeServices.AddTwoNumbers(num1, num2);
        }
    }
}