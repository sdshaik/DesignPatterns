using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityEx

{
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public object Handle(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
