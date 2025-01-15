using UnityEngine;
using System;
namespace Task29
{

    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 100;
            int diviser = 0;

            try
            {
                Console.WriteLine("Attempting to calculate score multiplier...");
                int totalScore = playerScore / diviser;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Console.WriteLine("Score calculation complete. Cleaning up resources.");
            }
        }
    }
}