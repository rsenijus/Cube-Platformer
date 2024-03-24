using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public float speed = 1.0f;
    private Vector3 moveVector;
    public bool isGrounded;
    public Vector3 jump;
    public float jumpForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveVector.z = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            moveVector.z = -1;
        }
        else
        {
            moveVector.z = 0;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveVector.x = 1;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            moveVector.x = -1;
        }
        else
        {
            moveVector.x = 0;
        }
        rb.MovePosition(rb.position + moveVector * speed);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }
}
