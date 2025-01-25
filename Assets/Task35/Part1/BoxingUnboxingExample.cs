using UnityEngine;
namespace Task35
{


    public class BoxingUnboxingExample : MonoBehaviour
    {
        void Start()
        {
            int number = 42;             
            object boxedNumber = number;  

            Debug.Log(boxedNumber);        

            int unboxedNumber = (int)boxedNumber; 
            Debug.Log(unboxedNumber);          
        }
    }
}