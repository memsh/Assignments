using UnityEngine;
namespace Task29
{


    public class UnitySpecificScriptP6 : MonoBehaviour
    {
        private GameObject joker;
        private GameObject targetObject;
        private Light lightObject;

        void OnEnable()
        {
            Debug.Log("GameObject Enabled");
        }

        void OnDisable()
        {
            Debug.Log("GameObject Disabled");
        }

        void Start()
        {
            Debug.Log("Game started!");

            // Find objects by name, tag, and type
            targetObject = GameObject.Find("TargetObject");
            if (targetObject != null)
            {
                Debug.Log($"Found object by name: {targetObject.name}");
            }
            else
            {
                Debug.Log("No TargetObject found.");
            }

            joker = GameObject.FindGameObjectWithTag("Joker");
            if (joker != null)
            {
                Debug.Log($"Found object by tag: {joker.name}");
            }
            else
            {
                Debug.Log("No Joker object found.");
            }

            lightObject = GameObject.FindObjectOfType<Light>();
            if (lightObject != null)
            {
                Debug.Log($"Found object of type Light: {lightObject.name}");
            }
            else
            {
                Debug.Log("No Light object found.");
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D) && targetObject != null)
            {
                targetObject.SetActive(false);
                Debug.Log("TargetObject deactivated!");
            }
        }
    }
}