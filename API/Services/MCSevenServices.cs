using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class MCSevenServices
    {
    public string ReverseItNumeric(int num4)
        {string reversednum = "";
            for (int i = num4.ToString().Length-1; i >=0; i--)
            {
                reversednum += num4.ToString()[i];
            }
        return $"The number {num4} backwards is {reversednum}.";
        }

    }
}