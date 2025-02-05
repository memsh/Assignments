using UnityEngine;
namespace Task35
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample example = new DerivedClassExample();
            example.PerformAction();
            example.PrintInfo();
        }
    }
}