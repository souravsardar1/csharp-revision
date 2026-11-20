using System;

namespace MyPract
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks.RunTasks(args);

            int[] numbers = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[] scores = { 10, 20, 30, 40, 50 };

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            List<int> nums = new List<int>();
            nums.Add(100);
            nums.Add(200);
            nums.Add(300);

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            List<string> names = new List<string> ();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");
            names.Add("Diana");
            names.Add("Eve");
            names.Add("Frank");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAt(2); // Remove "Charlie"

            bool containsCharlie = names.Contains("Charlie");
            Console.WriteLine($"Contains Charlie: {containsCharlie}");
            Console.WriteLine($"Count of names: {names.Count}");

            //names.Clear(); clears everything in the list

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Alice", 25);
            ages.Add("Bob", 30);
            ages.Add("Charlie", 35);
            ages.Add("Diana", 28);
            ages.Add("Eve", 22);

            Console.WriteLine($"Alice's age: {ages["Alice"]}");

            ages["Bob"] = 31; // Update Bob's age
            Console.WriteLine($"Bob's updated age: {ages["Bob"]}");


            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }



        }
    }
}