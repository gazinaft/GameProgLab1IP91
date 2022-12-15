using System;
using System.Collections;
using System.Collections.Generic;
using Command;
using PlayerState;
using UnityEngine;

public class MainCharacterOop : MonoBehaviour, StatefullMC
{
    float moveVelocity;

    public float speed;
    
    private Rigidbody2D _rigidbody2D;
    public PlayerState.PlayerState State { get; set; }
    private Controls _controls; 

    private void Start()
    {
        _controls = new DefaultControls(speed);
        State = new Grounded();
        _rigidbody2D = GetComponent<Rigidbody2D> ();
    }

    void Update () 
    {
        //Jumping
        if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Z) || Input.GetKeyDown (KeyCode.W)) 
        {
            State.Upwards(_rigidbody2D);
        }

        _controls.Stop(_rigidbody2D);
        if (Input.GetKey (KeyCode.A)) 
        {
            _controls.Left(_rigidbody2D);
        }
        if (Input.GetKey (KeyCode.D)) 
        {
            _controls.Right(_rigidbody2D);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        State.CollideIn(this);
    }

    void OnCollisionExit2D()
    {
        State.CollideOut(this);
    }

}