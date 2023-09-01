using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeEg
{
    internal class BasicRemoteControl : RemoteControl
    {
        public BasicRemoteControl(IDevice device) : base(device)
        {
            
        }

        public override void TurnOn()
        {
            Console.Write("Basic remote: ");
            _device.TurnOn();
        }

        public override void TurnOff()
        {
            Console.Write("Basic remote: ");
            _device.TurnOff();
        }
    }
}
