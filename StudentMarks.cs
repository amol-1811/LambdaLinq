namespace LambdaLinq
{
    internal class StudentMarks
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public StudentMarks(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }
        public static void StudentMarksGreaterThanEighty()
        {
            List<StudentMarks> students = new List<StudentMarks>
            {
                new StudentMarks("Amol", 92),
                new StudentMarks("Rishikesh", 45),
                new StudentMarks("Tanmay", 82),
                new StudentMarks("Pooja", 89),
                new StudentMarks("Asmita", 48),
                new StudentMarks("Disha", 55)
            };
            //using lambda expression
            var highMarks = students.Where(e => e.Marks > 80).Select(e => e.Name).ToList();
            foreach (var student in highMarks)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
