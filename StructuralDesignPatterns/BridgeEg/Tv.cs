using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeEg
{
    public class Tv : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("TV is turned on");
        }

        public void TurnOn()
        {
            Console.WriteLine("TV is turned on");
        }
    }
}
