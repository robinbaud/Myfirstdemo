
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public GameObject ground;
    public CharacterController controller ;
    public float speed = 15f;
    public float gravity = -9.81f;
    public float Jumpheight = 3f;

    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    Vector3 velocity;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(Jumpheight * -2f * gravity);
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void fall ()
    {
        ground = GameObject.Find("ground");
        if (transform.position.y < ground.transform.position.y - 10f)
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
    }
}
