using System;
using UnityEngine;
namespace Task29
{
    public class ScoreCalculator : MonoBehaviour
    {
        public int playerScore = 100;
        public int divisor = 0;

        void Start()
        {
            CalculateScore();
        }

        void CalculateScore()
        {
            try
            {
                Debug.Log("Attempting to calculate score multiplier...");
                int totalScore = playerScore / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        }
    }
}
