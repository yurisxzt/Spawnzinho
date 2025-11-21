using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    private Rigidbody rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v) * speed;
        Vector3 vel = new Vector3(dir.x, rb.linearVelocity.y, dir.z);
        rb.linearVelocity = vel;

        // Pular somente se estiver no ch�o
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // evita double jump
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // considera "ch�o" qualquer coisa com collider
        isGrounded = true;
    }
}