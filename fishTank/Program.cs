using System;

namespace fishTank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int aqVolume = length * width * height;
            double literVolume = aqVolume * 0.001;
            double needed = literVolume * (1 - percentage / 100);

            Console.WriteLine(needed);
        }
    }
}