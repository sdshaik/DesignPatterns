using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeEg
{
    internal class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
            
        }

        public override void TurnOn()
        {
            Console.Write("Advanced remote: ");
            _device.TurnOn();
        }

        public override void TurnOff()
        {
            Console.Write("Advanced remote: ");
            _device.TurnOn();
        }
    }
}
