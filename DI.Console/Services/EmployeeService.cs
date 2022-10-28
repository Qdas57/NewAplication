using DI.Console.Abstractions;
using DI.Console.Models;

namespace DI.Console.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> data = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FullName = "Carl Jonson",
                Position = "Junior Backend dev",
                Experience = 0.5,
                Salary = 500
            },
            new Employee()
            {
                Id = 2,
                FullName = "Rider",
                Position = "Middle Backend dev",
                Experience = 1.5,
                Salary = 1500
            },
            new Employee()
            {
                Id = 3,
                FullName = "Sweet",
                Position = "UX/UI designer",
                Experience = 2,
                Salary = 2000
            },
            new Employee()
            {
                Id = 4,
                FullName = "Big Smoke",
                Position = "SysAdminsitartor",
                Experience = 3.5,
                Salary = 3500
            },

        };
        
        public void PrintEmployeeList(int page = 1, int pageSize = 10)
        {
            //TODO: Реализовать по страничный вывод
            System.Console.WriteLine("EmployeeService");
        }
    }
}
