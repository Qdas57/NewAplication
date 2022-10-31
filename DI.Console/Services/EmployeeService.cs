using DI.Console.Abstractions;
using DI.Console.Models.Data;

namespace DI.Console.Services
{
    public class EmployeeService : IEmployeeService
    {
        public void PrintEmployeeList(int page = 1, int pageSize = 10)
        {
            //TODO: постраничный вывод
            foreach (var emp in DataProvider.employees)
            {
                System.Console.WriteLine(emp.ToString());
            }
        }
    }
}
