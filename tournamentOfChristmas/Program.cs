using System;

namespace tournamentOfChristmas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());
            double totalMoney = 0.0;
            int totalGamesWon = 0;
            int totalGamesLost = 0;

            for (int i = 1; i <= tournamentDays; i++)
            {
                double moneyForTheDay = 0.0;
                int gamesWon = 0;
                int gamesLost = 0;
                while (true)
                {
                    string sportType = Console.ReadLine();

                    if (sportType == "Finish")
                    {
                        break;
                    }
                    else
                    {
                        string outcome = Console.ReadLine();

                        if (outcome == "win")
                        {
                            gamesWon += 1;
                            moneyForTheDay += 20;
                        }
                        else if (outcome == "lose")
                        {
                            gamesLost += 1;
                        }
                        
                    }
                    
                }
                if (gamesWon > gamesLost)
                {
                    moneyForTheDay += moneyForTheDay * 0.1;
                }

                totalGamesWon += gamesWon;
                totalGamesLost += gamesLost;
                totalMoney += moneyForTheDay;
            }

            if (totalGamesWon > totalGamesLost)
            {
                totalMoney += totalMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:.00}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:.00}");
            }
        }
    }
}