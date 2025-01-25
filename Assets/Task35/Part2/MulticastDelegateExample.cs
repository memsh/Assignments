using UnityEngine;
namespace Task35
{


    delegate void MathOperation(int number);
    public class MulticastDelegateExample : MonoBehaviour
    {
        // Define the delegate
        delegate void MathOperation(int number);

        // Method to double the input number
        void DoubleNumber(int number)
        {
            Debug.Log("Double: " + (number * 2));
        }

        // Method to square the input number
        void SquareNumber(int number)
        {
            Debug.Log("Square: " + (number * number));
        }

        // Method to cube the input number
        void CubeNumber(int number)
        {
            Debug.Log("Cube: " + (number * number * number));
        }

        void Start()
        {
            // Subscribe the methods to the delegate using the += operator
            MathOperation operation = DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;

            // Invoke the delegate with the input value
            operation(5);
        }
    }
}