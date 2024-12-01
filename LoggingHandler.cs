using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class LoggingHandler : HandlerBase
    {
        protected override bool Process(Request request)
        {
            Console.WriteLine($"[Logging] Запрос на событие '{request.EventType}': {request.Content}");
            return true; 
        }
    }
}
