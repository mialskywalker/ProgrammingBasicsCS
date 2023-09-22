using System;

namespace careOfPuppy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int boughtFoodinKG = int.Parse(Console.ReadLine());
            double boughtFood = boughtFoodinKG * 1000;
            string command = "";
            double eaten = 0.0;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Adopted")
                {
                    break;
                }
                else
                {
                    eaten += int.Parse(command);
                }
            }

            double difference = boughtFood - eaten;

            if (difference >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {difference} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(difference)} grams more.");
            }
        }
    }
}