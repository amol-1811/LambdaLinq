namespace LambdaLinq
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name} -  ${Salary}";
        }


        public static void EmployeeSalary()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee("Amol", 60000),
            new Employee("Rishikesh", 45000),
            new Employee("Tanmay", 70000),
            new Employee("Pooja", 52000),
            new Employee("Asmita", 48000),
            new Employee("Disha", 55000)
        };

            //using lambda expression
            List<Employee> highEarners = employees.Where(e => e.Salary > 50000).ToList();
            
            foreach(Employee employee in highEarners)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();

            //using LINQ
            List<Employee> highEarnersL = (from e in employees where e.Salary > 50000 select e).ToList();

            foreach( Employee employee in highEarnersL)
            {
                Console.WriteLine(employee);
            }
        }
    }
    
}
