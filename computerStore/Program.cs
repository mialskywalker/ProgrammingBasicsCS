using System;

namespace computerStore
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            double totalPrice = 0.0;
            double taxes = 0.0;
            bool special = false;

            while (true)
            {

                string command = Console.ReadLine();

                if (command == "special")
                {
                    special = true;
                    break;
                }
                else if (command == "regular")
                {
                    special = false;
                    break;
                }
                else
                {
                    double partPrice = double.Parse(command);

                    if (partPrice < 0)
                    {
                        Console.WriteLine("Invalid price!");
                    }
                    else
                    {
                        totalPrice += partPrice;
                        taxes += partPrice * 0.2;
                    }
                    
                }

            }

            double result = totalPrice + taxes;

            if (special)
            {
                result -= result * 0.1;
            }

            if (result == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:.00}$");
                Console.WriteLine($"Taxes: {taxes:.00}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {result:.00}$");
            }

        }
    }
}