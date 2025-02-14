using System;
using LambdaLinq;

class Program
{
    public static void Main(string[] args)
    {
        /*//B1. Filter all even numbers from a list of integers.
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        List<int> evenNum = numbers.Where(numbers => numbers % 2 == 0).ToList(); // it's a linq method
        //List<int> evenNum = numbers.FindAll(numbers => numbers % 2 == 0) // it is List<T> method.

        Console.WriteLine("Using Lambda expression");
        foreach (var num in evenNum)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Using Linq query");
        List<int> nums = (from n in numbers where n % 2 == 0 select n).ToList();
        foreach (int n in nums)
        {
            Console.WriteLine(n);
        }*/
        //GreaterThanFifty();
        //CountChar();
        //Distinct();
        //SumOfOdd();
        //FindMax();
        //SquareOfNum();
        //FilterString();
        //Intermediate.TopThree();
        //Employee.EmployeeSalary();
        //Intermediate.CheckAllPositive();
        //Intermediate.FirstDivisibleByThreeFive();
        //Intermediate.CombineLists();
       // StudentMarks.StudentMarksGreaterThanEighty();
       Intermediate.LongestString();
    }

    public static void GetLetter()
    {
        // B2) Find strings starting with the letter 'A' in a list of strings.
        List<string> strings = new List<string>() { "Amol", "Baliram", "Gosavi", "Abhishek", "Apple" };
        List<string> letter = strings.Where(s => s.StartsWith("A")).ToList();
        Console.WriteLine("Using Lambda Expression :");
        foreach (string s in letter)
        {
            Console.WriteLine(s);
        }
        List<string> letterL = (from s in strings where s.StartsWith("A") select s).ToList();
        Console.WriteLine("Using Linq method :");
        foreach (string str in letterL)
        {
            Console.WriteLine(str);
        }
    }

    public static void SortDesc()
    {
        // B3) Sort a list of integers in descending order.
        List<int> numbers = new List<int>() { 1, 5, 3, 4, 2, 6, 8, 7, 9, 10 };
        List<int> sortedNum = numbers.OrderByDescending(n => n).ToList();
        Console.WriteLine("Using Lambda Expression :");
        foreach (int num in sortedNum)
        {
            Console.WriteLine(num + " ");
        }
        List<int> sortedNumL = (from n in numbers orderby n descending select n).ToList();
        Console.WriteLine("Using Linq method :");
        foreach (int n in sortedNumL)
        {
            Console.WriteLine(n + " ");
        }
    }

    public static void GreaterThanFifty()
    {
        List<int> numbers = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        List<int> greaterThanFifty = numbers.Where(n => n > 50).ToList();
        Console.WriteLine("Using Lambda Expression :");
        foreach (var num in greaterThanFifty)
        {
            Console.WriteLine(num);
        }

        List<int> greaterThanFiftyL = (from n in numbers where n > 50 select n).ToList();
        Console.WriteLine("Using Linq method :");
        foreach (var n in greaterThanFiftyL)
        {
            Console.WriteLine(n);
        }
    }

    public static void CountChar()
    {
        List<string> strings = new List<string>() { "Amol", "Baliram", "Gosavi", "pooja" };

        //int str = strings.Where(n => n.Length > 5).Count();
        int str = strings.Count(n => n.Length > 5);
        Console.WriteLine("Count of strings having more than 5 characters : " + str);

        int strL = (from n in strings where n.Length > 5 select n).Count();
        Console.WriteLine("Count of strings having more than 5 characters (Using LINQ) : " + strL);
    }

    public static void Distinct()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 };

        List<int> distinctNum = numbers.Distinct().ToList();
        Console.WriteLine("Using Lambda Expression :");
        foreach (var num in distinctNum)
        {
            Console.WriteLine(num);
        }

        List<int> distinctNumL = (from n in numbers select n).Distinct().ToList();
        Console.WriteLine("Using Linq method :");
        foreach (var n in distinctNumL)
        {
            Console.WriteLine(n);
        }

        //Console.WriteLine(string.Join(",", distinctNum));
        //Console.WriteLine(string.Join(",", distinctNumL));

        HashSet<int> distinctNumH = new HashSet<int>(numbers);
        Console.WriteLine("Using HashSet :");
        foreach (var n in distinctNumH)
        {
            Console.WriteLine(n);
        }
    }

    public static void SumOfOdd()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = numbers.Where(n => n % 2 != 0).Sum();
        Console.WriteLine("Sum of odd numbers : " + sum);

        int sumL = (from n in numbers where n % 2 != 0 select n).Sum();
        Console.WriteLine("Sum of odd numbers using LINQ : " + sumL);
    }

    public static void FindMax()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int max = numbers.Max();
        Console.WriteLine("Max number : " + max);

        int maxL = (from n in numbers select n).Max();
        Console.WriteLine("Max number using LINQ : " + maxL);
    }

    public static void SquareOfNum()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //List<int> square = numbers.Select(n => n * n).ToList();
        List<int> square = numbers.ConvertAll(n => n * n);
        Console.WriteLine("Using Lambda Expression :");
        foreach (var num in square)
        {
            Console.WriteLine(num);
        }
        
        List<int> squareLinq = (from n in numbers select n * n).ToList();
        Console.WriteLine("Using Linq method :");
        foreach (var n in squareLinq)
        {
            Console.WriteLine(n);
        }
    }
    // Filter a list of strings to only include those ending with ".com".
    public static void FilterString()
    {
        List<string> strings = new List<string>() { "google.com", "Amol", "yahoo.com", "github.com", "Gmail" };
        List<string> str = strings.Where(s => s.EndsWith(".com")).ToList();
        Console.WriteLine("Using Lambda Expression :");
        foreach (string s in str)
        {
            Console.WriteLine(s);
        }

        List<string> strL = (from s in strings where s.EndsWith(".com") select s).ToList();
        Console.WriteLine("Using Linq method :");
        foreach (string s in strL)
        {
            Console.WriteLine(s);
        }

        //Console.WriteLine(string.Join(",", str));
    }
}