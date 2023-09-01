using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeEg
{
    public class Radio : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("Radio is turned on.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Radio is turned off.");
        }
    }
}
