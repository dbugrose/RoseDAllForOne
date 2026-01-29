using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class MCFiveServices
    {
        public string OddOrEven(int num3)
        {
            return num3 % 2 == 0 ? "This number is even!" : "This number is odd!";
        }
    }
}