using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public ObstacleMovement movement;
    public GameObject[] g_object;
    public Rigidbody rb;

    void OnCollisionEnter(Collision collisionInfo)
    {
        foreach (GameObject o in g_object)
        {
            if (collisionInfo.collider.tag == "Obstacle")
            {
                movement.enabled = false;
            }
        }
        
    }
}
