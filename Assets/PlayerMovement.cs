using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController characterController;

    public float speed = 12f;
    public float gravity = -9.8f;
    public float jump = 3f;


    public Transform groundChek;
    public float distance = 0.4f;
    public LayerMask graoundMask;
    bool isGrounded;

    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundChek.position, distance, graoundMask);

        if (isGrounded && velocity.y < 0 )
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed* Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        if (Input.GetButton("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }
        characterController.Move(velocity * Time.deltaTime);
    }
}
