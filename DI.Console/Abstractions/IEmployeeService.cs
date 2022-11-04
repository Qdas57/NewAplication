namespace DI.Console.Abstractions
{
    public interface IEmployeeService
    {
        void PrintEmployeeList(int page = 1, int pageSize = 10);
        
    }
    
}
