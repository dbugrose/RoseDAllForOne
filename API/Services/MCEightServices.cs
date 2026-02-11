using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class MCEightServices
    {public string MagicEightBall()
        { string [] randomAnswer = ["Try again.", "Perhaps.", "Sure, why not?", "Not likely.", "Signs point to yes.", "My reply is no.", "Outlook is bright."];
           if (question.Contains("?"))
           { Random random = new Random();
            int rndNumber = random.Next(1, 9);
            return randomAnswer[rndNumber];
           }

           else
            {
                return "Please enter a valid question.";
            }
        }
    }
}