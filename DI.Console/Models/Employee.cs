namespace DI.Console.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Position { get; set; }

        public double Experience { get; set; }

        public double Salary { get; set; }

        public int DepartmentId { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} FullName: {FullName}\t\t Position: {Position}\t Salary: {Salary}";
        }
    }
}
