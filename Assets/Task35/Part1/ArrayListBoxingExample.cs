using UnityEngine;
using System.Collections;
namespace Task35
{


    public class ArrayListBoxingExample : MonoBehaviour
    {
        void Start()
        {
            ArrayList list = new ArrayList();

            // Boxing happens here
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (object o in list)
            {
                // Unboxing happens here
                int number = (int)o;
                Debug.Log(number);
            }
        }
    }
}