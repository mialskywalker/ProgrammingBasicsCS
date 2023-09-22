using System;

namespace foodForPets
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double eatenFoodForTheDay = 0.0;
            double biscuits = 0.0;
            double totalDog = 0.0;
            double totalCat = 0.0;

            for (int i = 1; i <= days; i++)
            {
                int dog = int.Parse(Console.ReadLine());
                int cat = int.Parse(Console.ReadLine());
                totalDog += dog;
                totalCat += cat;

                eatenFoodForTheDay = dog + cat;
                if (i % 3 == 0)
                {
                    biscuits += eatenFoodForTheDay * 0.1;
                }
            }

            double totalFoodEaten = totalDog + totalCat;
            double totalPercentage = totalFoodEaten / totalFood * 100;
            double dogPercentage = totalDog / totalFoodEaten * 100;
            double catPercentage = totalCat / totalFoodEaten * 100;
            
            
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{totalPercentage:.00}% of the food has been eaten.");
            Console.WriteLine($"{dogPercentage:.00}% eaten from the dog.");
            Console.WriteLine($"{catPercentage:.00}% eaten from the cat.");

        }
    }
}