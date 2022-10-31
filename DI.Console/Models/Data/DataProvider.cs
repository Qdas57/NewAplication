namespace DI.Console.Models.Data
{
    public static class DataProvider
    {
        public static readonly List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FullName = "CJ",
                Position = "Junior Backend dev",
                Experience = 0.5,
                Salary = 500,
                DepartmentId = 1
            },
            new Employee()
            {
                Id = 2,
                FullName = "Rider",
                Position = "Middle Backend dev",
                Experience = 1.5,
                Salary = 1500,
                DepartmentId = 1
            },
            new Employee()
            {
                Id = 3,
                FullName = "Sweet",
                Position = "UX/UI designer",
                Experience = 2,
                Salary = 2000,
                DepartmentId = 3
            },
            new Employee()
            {
                Id = 4,
                FullName = "Smoke",
                Position = "SysAdminsitartor",
                Experience = 3.5,
                Salary = 3500,
                DepartmentId = 2
            },

        };

        public static readonly List<Department> departments = new List<Department>()
        {
            new Department()
            {
                Id = 1,
                Title = "IT",
                K = 1.2
            },
            new Department()
            {
                Id = 2,
                Title = "SysAdmin",
                K = 1.1
            },
            new Department()
            {
                Id = 3,
                Title = "Designers",
                K = 1.0
            }
        };
    }
}
