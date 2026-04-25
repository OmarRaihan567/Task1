using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Tesing










            
            // Task 1 Main Code

            // Welcome Message 
            Console.WriteLine("-- Welcome to Islam's Carpets Cleaning Service --");

            // User enters the number of each size of carpets he wants to clean
            Console.Write("Enter the number of small carpets you want to clean: ");
            int SCC = Convert.ToInt32(Console.ReadLine()); // SCC -> SmallCarpetsCount
            
            Console.Write("Enter the number of Large carpets you want to clean: ");
            int LCC = Convert.ToInt32(Console.ReadLine()); // LCC -> LargeCarpetsCount

            // initalizing Cost & Tax & Total estimate variables
            int Cost = (SCC * 25) + (LCC * 35);
            double Tax = 0.06 * Cost;
            double Total_estimate = Cost + Tax;

            // The Final Estimate
            Console.WriteLine("-- Estimate for carpet cleaning service --");

            Console.WriteLine($"Number of small carpets is: {SCC}");
            Console.WriteLine($"Number of Large carpets is: {LCC}");

            Console.WriteLine("Price per small carpet is: $25");
            Console.WriteLine("Price per large carpet is: $35");

            Console.WriteLine($"The Cost of the carpets: {Cost}");
            Console.WriteLine($"The total Tax: {Tax}");

            Console.WriteLine("==================================");

            Console.WriteLine($"Total estimate: {Total_estimate}");
            Console.WriteLine("This estimate is valid for 30 days");

            Console.WriteLine("- Thank you for dealing with us! -");
            
        }
    }
}
