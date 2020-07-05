using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float ForwardForce = 2000f;
    //void Start()
    //{
    //    rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationX;
    //}

    void FixedUpdate()
    {
        rb.AddForce(0, 0, -(ForwardForce * Time.deltaTime));
    }
}
