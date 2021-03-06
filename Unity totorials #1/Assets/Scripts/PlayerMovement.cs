﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    CharacterController charController;

    [SerializeField] float jumpSpeed = 20.0f;
    //seting up variables that can be seen in the inspecter due to them being serialzed

    [SerializeField] float gravity = 1.0f;
    float yVelocity = 0.0f;


    [SerializeField] float movespeed = 5.0f;
    public float h;
    public float v;

    // Use this for initialization
    void Start () {
        charController = GetComponent<CharacterController>();
        //geting the charicter controller
	}
	
	// Update is called once per frame
	void Update () {
        h = Input.GetAxis("Horizontal");
        //when the h or v key is held down then it will get the Horizontal and vertical Axis

        v = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(h, 0, v);
        //useing the infomation from vector 3 to move the player

        Vector3 velocity = direction * movespeed;

        if (charController.isGrounded)
        //check to see if the charicter is on the ground
        {                              
            // if the charicter is grounded, then the player can use the jump button to jump
            if(Input.GetButtonDown("Jump"))
            {
                yVelocity = jumpSpeed;
            }
        }
        else
        {
            yVelocity -= gravity;
            //if the player is in mid jump the y velocity will equal gravity thus gring the player to the ground
        }
        velocity.y = yVelocity;

        velocity = transform.TransformDirection(velocity);

        charController.Move(velocity * Time.deltaTime);
        //pasing the colcity on to the cahricter contoller to tell it how fast to move and in which direction
        
	}
}
