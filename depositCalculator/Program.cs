using System;

namespace depositCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double gdp = double.Parse(Console.ReadLine());

            double result = deposit + ((deposit * gdp / 100) / 12) * term;

            Console.WriteLine(result);
        }
    }
}