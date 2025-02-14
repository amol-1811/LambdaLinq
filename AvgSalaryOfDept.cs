namespace LambdaLinq
{
    internal class Employee2
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee2(string name, string department, decimal salary)
        {
            Department = department;
            Name = name;
            Salary = salary;
        }

        public static void GetAvgSalary()
        {
            List<Employee2> employees = new List<Employee2>()
            {
                new Employee2("Amol", "HR", 60000),
                new Employee2("Amar", "IT", 75000),
                new Employee2("Rishi", "IT", 80000),
                new Employee2("tannie", "HR", 55000),
                new Employee2("pooja", "Finance", 70000),
                new Employee2("Asmita", "Finance", 72000)
            };

            var avgSalaries = employees.GroupBy(e => e.Department)
                .Select(g => new {Department = g.Key, AvgSalary = g.Average(e => e.Salary)}).ToList();

            Console.WriteLine("Average salary by department : ");
            foreach(var employee in avgSalaries)
            {
                Console.WriteLine($"Department : {employee.Department}, Average Salary: {employee.AvgSalary:C}");
            }
        }
    }
}
