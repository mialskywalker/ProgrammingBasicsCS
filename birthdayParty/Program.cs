using System;

namespace birthdayParty
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double roomRent = double.Parse(Console.ReadLine());

            double cakePrice = roomRent * 0.2;
            double drinksPrice = cakePrice - (cakePrice * 0.45);
            double animator = roomRent / 3;
            double needed = roomRent + cakePrice + drinksPrice + animator;

            Console.WriteLine(needed);
        }
    }
}