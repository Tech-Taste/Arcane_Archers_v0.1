using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour

    
{
    public float runSpeed = 2;
    public float jumpSpeed = 3;
    Rigidbody2D rb2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a")||Input.GetKey("right")) 
        { 
            rb2D.linearVelocity=new Vector2(runSpeed,rb2D.linearVelocity.y);
        }
        else if (Input.GetKey("d") || Input.GetKey("left"))
        {
            rb2D.linearVelocity = new Vector2(-runSpeed, rb2D.linearVelocity.y);
        }
        else
        {
            rb2D.linearVelocity=new Vector2(0,rb2D.linearVelocity.y);
        }

        if (Input.GetKey("space") ||Input.GetKey("up") && CheckGround.isGrounded)
        {
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, jumpSpeed);
        }

    }
}
