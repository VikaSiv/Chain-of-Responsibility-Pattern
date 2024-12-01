using System;
using Chain_of_Responsibility_Pattern;
using ChainOfResponsibilityExample;


namespace ChainOfResponsibilityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var loggingHandler = new LoggingHandler();
            var authenticationHandler = new AuthenticationHandler();
            var validationHandler = new ValidationHandler();

            
            loggingHandler.SetNext(authenticationHandler);
            authenticationHandler.SetNext(validationHandler);

            var request1 = new Request("Authentication", "Проверка пользователя");
            var request2 = new Request("Validation", "Валидация данных формы");
            var request3 = new Request("Other", "Обработка общего события");

            Console.WriteLine("Обрабатываем запрос 1:");
            loggingHandler.Handle(request1);

            Console.WriteLine("\nОбрабатываем запрос 2:");
            loggingHandler.Handle(request2);

            Console.WriteLine("\nОбрабатываем запрос 3:");
            loggingHandler.Handle(request3);
        }
    }
}
