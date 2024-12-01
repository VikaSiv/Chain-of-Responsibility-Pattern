using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public abstract class HandlerBase
    {
        private HandlerBase? _nextHandler;

        public void SetNext(HandlerBase nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void Handle(Request request)
        {
            if (Process(request))
            {
                _nextHandler?.Handle(request);
            }
        }

        protected abstract bool Process(Request request);
    }
}
