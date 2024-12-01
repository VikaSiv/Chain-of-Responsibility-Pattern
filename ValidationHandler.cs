using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class ValidationHandler : HandlerBase
    {
        protected override bool Process(Request request)
        {
            if (request.EventType == "Validation")
            {
                Console.WriteLine("[Validation] Проверка данных запроса...");
                return false; 
            }

            return true;
        }
    }
}
