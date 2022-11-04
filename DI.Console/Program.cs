using Autofac;
using DI.Console.Abstractions;
using DI.Console.Services;

namespace DI.Console
{
    public class Program
    {
        public static IEmployeeService empService;
        public static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<SecondEmployeeService>().As<IEmployeeService>();
            var container = builder.Build();
            empService = container.Resolve<IEmployeeService>();
            empService.PrintEmployeeList();
        }
    }
}
