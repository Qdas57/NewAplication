using DI.Console.Abstractions;

namespace DI.Console.Services
{
    internal class SecondEmployeeService : IEmployeeService
    {
        public void PrintEmployeeList(int page = 1, int pageSize = 10)
        {
            System.Console.WriteLine("SecondEmployeeService");
        }
    }
}
