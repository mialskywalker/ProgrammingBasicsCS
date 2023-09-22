using System;

namespace RadiansToDegrees
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double degrees = rad * 180 / Math.PI;

            Console.WriteLine(degrees);

        }
    }
}