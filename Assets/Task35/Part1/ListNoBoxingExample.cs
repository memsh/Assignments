using UnityEngine;
using System.Collections.Generic;
namespace Task35
{


    public class ListNoBoxingExample : MonoBehaviour
    {
        void Start()
        {
            List<int> list = new List<int>();

            // No boxing, as List<int> handles int types directly
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (int number in list)
            {
                Debug.Log(number);
            }
        }
    }
}