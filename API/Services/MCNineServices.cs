using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class MCNineServices
    {
        public string guessANumber1to10(int num5)
        {
            Random random = new Random();
            int randomNum = random.Next(1, 11);
            if (num5 == randomNum)
            {return $"You got it! The number was {randomNum}.";}
            else if (num5 > randomNum)
            {
            return $"Sorry, that's too high. The number was {randomNum}.";
            }
            else
            {
            return $"Sorry, that's too low. The number was {randomNum}.";
            }
        }

        public string guessANumber1to50(int num6)
        {
            Random random = new Random();
            int randomNum = random.Next(1, 51);
            if (num6 == randomNum)
            {return $"You got it! The number was {randomNum}.";}
            else if (num6 > randomNum)
            {
            return $"Sorry, that's too high. The number was {randomNum}.";
            }
            else
            {
            return $"Sorry, that's too low. The number was {randomNum}.";
            }
        }

                public string guessANumber1to100(int num7)
        {
            Random random = new Random();
            int randomNum = random.Next(1, 101);
            if (num7 == randomNum)
            {return $"You got it! The number was {randomNum}.";}
            else if (num7 > randomNum)
            {
            return $"Sorry, that's too high. The number was {randomNum}.";
            }
            else
            {
            return $"Sorry, that's too low. The number was {randomNum}.";
            }
        }
    }
}