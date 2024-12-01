using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class AuthenticationHandler : HandlerBase
    {
        protected override bool Process(Request request)
        {
            if (request.EventType == "Authentication")
            {
                Console.WriteLine("[Authentication] Обработка запроса на аутентификацию...");
                return false; 
            }

            return true; 
        }
    }
}
