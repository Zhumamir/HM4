using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM4
{
    public partial class Train
    {
        public void StartJourney()
        {
            if (isOperational)
            {
                Console.WriteLine($"Train {trainNumber} is starting its journey.");
            }
            else
            {
                Console.WriteLine($"Train {trainNumber} cannot start the journey as it is not operational.");
            }
        }
    }
}
