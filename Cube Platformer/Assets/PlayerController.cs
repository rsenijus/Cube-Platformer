using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] public float speed = 1.0f;
    private Vector3 moveVector;
    private bool isGrounded;
    private Vector3 jump;
    [SerializeField] public float jumpForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.z = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    private void OnCollisionExit()
    {
        isGrounded = false;
    }
}
