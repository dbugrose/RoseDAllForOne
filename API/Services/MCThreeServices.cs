using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class MCThreeServices
    {
    public string AddTwoNumbers(int num1, int num2)
        {int sum = num1+num2;
            return $"The sum of {num1} and {num2} is {sum}.";
        }
    }
}