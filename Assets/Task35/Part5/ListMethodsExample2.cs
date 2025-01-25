using System.Collections.Generic;
using UnityEngine;
namespace Task35
{


    public class ListMethodsExample2 : MonoBehaviour
    {
        void Start()
        {
            // Step 1: Create a List of Integers
            List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };

            // Step 2: Use the FindAll Method to find all even numbers
            List<int> filteredNumbers = numbers2.FindAll(number => number % 2 == 0);

            // Step 3: Print the Results
            Debug.Log(string.Join(", ", filteredNumbers));
        }
    }
}