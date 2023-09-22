using System;

namespace energyBooster
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());

            double fruitPrice = 0.0;
            int numbers = 0;

            switch (fruit)
            {
                case "Watermelon":
                    if (size == "big")
                    {
                        fruitPrice = 28.70;
                        numbers = 5;
                    }
                    else if (size == "small")
                    {
                        fruitPrice = 56;
                        numbers = 2;
                    }

                    break;
                case "Mango":
                    if (size == "big")
                    {
                        fruitPrice = 19.60;
                        numbers = 5;
                    }
                    else if (size == "small")
                    {
                        fruitPrice = 36.66;
                        numbers = 2;
                    }

                    break;
                case "Pineapple":
                    if (size == "big")
                    {
                        fruitPrice = 24.80;
                        numbers = 5;
                    }
                    else if (size == "small")
                    {
                        fruitPrice = 42.10;
                        numbers = 2;
                    }

                    break;
                case "Raspberry":
                    if (size == "big")
                    {
                        fruitPrice = 15.20;
                        numbers = 5;
                    }
                    else if (size == "small")
                    {
                        fruitPrice = 20;
                        numbers = 2;
                    }

                    break;

            }

            double total = fruitPrice * sets * numbers;

            if (400 <= total && total <= 1000)
            {
                total -= total * 0.15;
            }
            else if (total > 1000)
            {
                total -= total * 0.5;
            }

            string result = total.ToString("0.00");
            
            Console.WriteLine($"{result} lv.");
        }
    }
}