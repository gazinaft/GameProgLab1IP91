using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterProcedural : MonoBehaviour
{
    public float speed;
    public float jump;
    float moveVelocity;

    //Grounded Vars
    bool grounded = true;
    private Rigidbody2D _rigidbody2D;


    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D> ();
    }

    void Update () 
    {
        //Jumping
        if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Z) || Input.GetKeyDown (KeyCode.W)) 
        {
            if(grounded)
            {
                _rigidbody2D.velocity = new Vector2 (_rigidbody2D.velocity.x, jump);
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
        {
            moveVelocity = speed;
        }

        _rigidbody2D.velocity = new Vector2 (moveVelocity, _rigidbody2D.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        grounded = true;
    }

    //Check if Grounded
    void OnCollisionExit2D()
    {
        grounded = false;
    }
}
