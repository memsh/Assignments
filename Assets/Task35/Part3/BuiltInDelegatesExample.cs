using UnityEngine;
using System;
namespace Task35
{


    public class BuiltInDelegatesExample : MonoBehaviour
    {
        void Start()
        {
            // Action delegate example
            Action logMessage = () => Debug.Log("Hello from Action delegate!");
            logMessage();

            // Func delegate example
            Func<int, int> square = (x) => x * x;
            Debug.Log($"Square: {square(5)}");

            // Predicate delegate example
            Predicate<int> isEven = (x) => x % 2 == 0;
            Debug.Log($"Is 4 even? {isEven(4)}");
        }
    }
}