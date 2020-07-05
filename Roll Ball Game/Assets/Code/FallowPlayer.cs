using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayer : MonoBehaviour
{
    public Transform player;
    Vector3 mesafe;
    
	void Start ()
    {
        mesafe = transform.position-player.position;
	}
	
    void Update ()
    {
        transform.position = player.position + mesafe;
	}
}
