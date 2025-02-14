namespace LambdaLinq
{
    internal class Intermediate
    {
        public static void GroupByFirstLetter()
        {
            List<string> names = new List<string>() { "Amol", "Baliram", "Gosavi", "pooja", "Tanmay" };
            
            var grpByFstLetter = names.GroupBy(n => n[0]);
            Console.WriteLine("Using Lambda Expression :");
            foreach (var grp in grpByFstLetter)
            {
                Console.WriteLine(grp.Key);
                foreach (var name in grp)
                {
                    Console.WriteLine(name);
                }
            }

            //Using Dictionary for grouping
            var dictionary = names.GroupBy(n => n[0]).ToDictionary(g => g.Key, g => g.ToList());
            Console.WriteLine("_____Dictionary______");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key : {item.Key}");
                foreach (var name in item.Value)
                {
                    Console.WriteLine($"Value : {name}");
                }
            }
        }

        public static void TopThree()
        {
            //Find the top 3 highest numbers in a list of integers.
            List<int> numbers = new List<int>() { 5, 2, 8, 1, 9, 3, 12, 4, 7, 10, 6, 11 };

            List<int> top3 = numbers.OrderByDescending(n => n).Take(3).ToList();
            //List<int> top3 = numbers.OrderBy(n => n).Reverse().Take(3).ToList();
            Console.WriteLine(string.Join(", ", top3));
        }

        public static void CheckAllPositive()
        {
            List<int> nums = new List<int>() { -1, 5, -6, 9, 8, 7, -4, 13, 10 };

            bool allPositive = nums.All(n => n > 0);

            Console.WriteLine(allPositive ? "All numbers are positive." : "not all numbers are positive");
            
            var negativeNums = nums.Where(n => n < 0).ToList();
            Console.WriteLine($"Negative numbers in a list : { string.Join(", ", negativeNums)}");
        }

        //Find the first number in a list that is divisible by 3 and 5
        public static void FirstDivisibleByThreeFive()
        {
            List<int> numbers = new List<int>() { 1, 2, 4, 6, 8, 9, 10, 12, 15, 18, 20 };
            //int num = numbers.First(n => n % 3 == 0 && n % 5 == 0);
            int num = numbers.FirstOrDefault(n => n % 3 == 0 && n % 5 == 0);
            Console.WriteLine("First number in a list divisible by 3 and 5 is :"+num);
        }

        //Combine two lists of integers into one list without duplicates.
        public static void CombineLists()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>() { 3, 4, 5, 6, 7 };

            //List<int> combinedList = list1.Concat(list2).Distinct().ToList();
            List<int> combined = list1.Union(list2).ToList();
            Console.WriteLine(string.Join(", ", combined));
        }

        //Find the longest string in a list of strings.
        public static void LongestString()
        {
            List<string> strings = new List<string>() { "Amol", "Baliram", "Gosavi", "Abhishek", "Apple" };

            string longest = strings.OrderByDescending(s => s.Length).First();
            //string longestString = strings.OrderByDescending(s => s.Length).FirstOrDefault();

            Console.WriteLine("Longest string in a list is : " + longest);
        }

        //Calculate the average of a list of floating-point numbers
        public static void AvgOfFloat()
        {
            List<double> nums = new List<double>() { 1.2, 5.6, 7.4, 9.1, 3.09 };
            double avg = nums.Average();

            Console.WriteLine("Average of the list :" + avg);
        }
    }
}
