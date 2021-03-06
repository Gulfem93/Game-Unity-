﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    //public float ForwardForce = 2000f;
    public float sidewaysForce = 500f;

    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
    }

    void FixedUpdate ()
    {
        //rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-(sidewaysForce * Time.deltaTime), 0, 0);
        }
	}
}
