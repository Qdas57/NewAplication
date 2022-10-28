using DI.Console.Abstractions;
using DI.Console.Services;

namespace DI.Console
{
    public class Program
    {
        public static IEmployeeService empService;

        static void Main(string[] args)
        {
            //TODO:
            //1.1 Добавить модель Отдел
            //1.2 Добавить поле отдел к Сотрудникам
            //2. Добавить данных в список сотрудников


            //TODO: 
            //1. Вывести весь список постранично
            //1.2 


            //TODO:
            // Применить DI-контейнер для регистрации зависимостей
            // Autofac
            // Nuget - установить Autofac
            // Посмотреть в доках как регистрировать зависимоти

            //TODO:
            //Использовать Autofac вместо:
            //empService = new EmployeeService();
            empService = new SecondEmployeeService();

            empService.PrintEmployeeList(2, 3);

        }
    }
}
