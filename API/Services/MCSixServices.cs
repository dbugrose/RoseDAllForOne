using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.ObjectPool;

namespace API.Services
{
    public class MCSixServices
    {
        public string ReverseItAlphanumeric(string alphanumeric)
        {string reversed = "";
            for (int i = alphanumeric.Length-1; i >=0; i--)
            {
                reversed += alphanumeric[i];
            }
        return $"'{alphanumeric}' backwards is '{reversed}'.";
        }
    }
}