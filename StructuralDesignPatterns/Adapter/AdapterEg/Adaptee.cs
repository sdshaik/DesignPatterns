using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEg
{
    public class Adaptee
    {
        public void SepicficRequest()
        {
            Console.WriteLine("Adaptee's specific request.");
        }
    }
}
