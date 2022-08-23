using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundLayerMask;
    public AudioSource footstepsSound;
    public AudioSource jumpSound;
    Vector3 velocity;
    bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayerMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (isGrounded && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                
            }
            else
            {
                footstepsSound.enabled = true;
                
            }
        }
        else
        {
            footstepsSound.enabled = false;
            
        }


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            jumpSound.Play();
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
    //Movement script for JumpPad and sorts. Case is "tag" 
    private void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        switch(hit.gameObject.tag)
        {
            case "JumpPad":
                jumpHeight = 20f;
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                //Debug.Log("BOUNCE!");
                jumpHeight = 3f;
                break;
            case "Ground":
                jumpHeight = 3f;
                break;
        }
    }
}
