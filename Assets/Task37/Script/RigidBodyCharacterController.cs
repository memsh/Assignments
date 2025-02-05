using UnityEngine;
namespace Task37
{
    public class RigidBodyCharacterController : MonoBehaviour
    {
        public float moveSpeed = 5f;
        public float jumpForce = 5f;
        private Rigidbody rb;
        private bool isGrounded;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * moveSpeed);

            if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                isGrounded = false;
            }
        }

        void OnCollisionStay()
        {
            isGrounded = true;
        }
    }
}