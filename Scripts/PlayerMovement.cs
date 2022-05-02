using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables used in class
    private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float jumpheight;
    private Animator animate;
    private bool grounded;

    //when code is launched gets the rigidbody comp from player and the animator from player
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();
    }

    private void Update()
    {
        //code that checks for A and D to be pressed and moves the player sprite at a set speed
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //flip player sprite
        if (horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale =new  Vector3(-0.5f,0.5f,1f);
        }
        //when space is pressed, run jump function
        if(Input.GetKey(KeyCode.Space) && grounded)
            Jump();

        //runs animation code 
        animate.SetBool("walk", horizontalInput != 0);
        animate.SetBool("grounded", grounded);
    }

    //jump function
    private void Jump()
        {
            //runs animation code and moves sprite upwards based on jumpheight variable set
            body.velocity = new Vector2(body.velocity.x, jumpheight);
            animate.SetTrigger("jump");
            grounded = false;
        }

    //checks if player is on the ground or platform
    private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.tag == "Ground")
                grounded = true;
        }
}
