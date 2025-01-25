using System.Collections.Generic;
using UnityEngine;
namespace Task35
{

    public class ListMethodsExample : MonoBehaviour
    {
        void Start()
        {
            // Step 2: Initialize a List<int> and populate it with values
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };

            // Step 3: Sort the list in descending order using a lambda expression
            numbers.Sort((x, y) => y.CompareTo(x));

            // Step 4: Print the results
            Debug.Log(string.Join(", ", numbers));
        }
    }

}