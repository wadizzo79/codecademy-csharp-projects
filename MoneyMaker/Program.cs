using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            
            Console.WriteLine("Enter the amount you wish to convert");

            string stringAmount = Console.ReadLine();
            // Validate input
            double amount;
            if (!double.TryParse(stringAmount, out amount))
            {
                Console.WriteLine("Please enter a valid number.");
                return;
            }
            // Ensure the amount is non-negative
            Console.WriteLine($"{amount} cents is equal to...");

            const double gold = 10;
            const double silver = 5;

            int goldCoins = (int)(amount / gold); // Calculate the number of gold coins

            double remainder = amount % gold; // Calculate the remaining amount after gold coins

            int silverCoins = (int)(remainder / silver); // Calculate the number of silver coins

            remainder = remainder % silver; // Calculate the remaining amount after silver coins

            Console.WriteLine($"Gold coins: {goldCoins}"); // Output the number of gold coins
            Console.WriteLine($"Silver coins: {silverCoins}"); // Output the number of silver coins
            Console.WriteLine($"Bronze coins: {remainder}"); // Output the remaining amount as bronze coins


        }
    }
}
