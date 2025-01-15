using UnityEngine;
namespace Task29
{


    public class RecursionScriptP7 : MonoBehaviour
    {
        void Start()
        {
            int n1 = 10;
            int n2 = 30;

            Debug.Log($"FibonacciRecursive({n1}) = {FibonacciRecursive(n1)}");
            Debug.Log($"FibonacciRecursive({n2}) = {FibonacciRecursive(n2)}");

            Debug.Log($"FibonacciIterative({n1}) = {FibonacciIterative(n1)}");
            Debug.Log($"FibonacciIterative({n2}) = {FibonacciIterative(n2)}");
        }

        int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}