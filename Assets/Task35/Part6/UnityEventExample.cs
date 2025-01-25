using UnityEngine;
using UnityEngine.Events;
namespace Task35
{


    public class UnityEventExample : MonoBehaviour
    {
        public UnityEvent onEventTriggered;

        void Start()
        {
            // Initialize the UnityEvent
            onEventTriggered = new UnityEvent();
            // Add a listener programmatically
            onEventTriggered.AddListener(OnEventResponse);
        }

        void Update()
        {
            // Trigger the UnityEvent when the Spacebar key is pressed
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Spacebar pressed"); // Confirm key press in the console
                onEventTriggered.Invoke();
            }
        }

        // Method that logs to the Console when the event is triggered
        void OnEventResponse()
        {
            Debug.Log("The event has been triggered!");
        }
    }
}