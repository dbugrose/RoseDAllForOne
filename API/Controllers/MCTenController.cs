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
    public class MCTenController : ControllerBase
    {
         private readonly MCTenServices _mcTenServices;

        public MCTenController(MCTenServices mcTenServices)
        {
            _mcTenServices = mcTenServices;
        }
            [HttpGet("TypeMexicanAsianOrFast/{foodcategory}")]
            public string RandomizedRestaurant(string foodcategory){
                return _mcTenServices.RandomizedRestaurant(foodcategory);
            }
    }
}