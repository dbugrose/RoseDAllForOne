using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class MCOneServices
    {
        public string GreetByName(string name)
        { if (!int.TryParse(name, out int numName))
            {return $"Hello, {name}!";}
            else
            {
                return "Please enter a valid name.";
            }
        }
    }
}