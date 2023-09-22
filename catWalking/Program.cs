using System;

namespace catWalking
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int minutesPerDay = int.Parse(Console.ReadLine());
            int numberOfWalksPerDay = int.Parse(Console.ReadLine());
            int caloriesTaken = int.Parse(Console.ReadLine());

            int totalWalkMins = numberOfWalksPerDay * minutesPerDay;
            int totalCaloriesBurned = totalWalkMins * 5;

            double caloriesNeeded = caloriesTaken * 0.5;

            if (caloriesNeeded <= totalCaloriesBurned)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesBurned}.");
            }
        }
    }
}