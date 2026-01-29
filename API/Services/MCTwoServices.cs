using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace API.Services
{
    public class MCTwoServices
    {
        public string NameAndWakeTime(string name, int wakeTime)
        {
            return $"Your name is {name} and you woke up at {wakeTime}. Neat!";
        }
    }
}