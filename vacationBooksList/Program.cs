using System;

namespace vacationBooksList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int totalPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hours = (totalPages / pagesPerHour) / days;
            Console.WriteLine(hours);
        }
    }
}