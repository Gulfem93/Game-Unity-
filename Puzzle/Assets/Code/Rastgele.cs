using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rastgele : MonoBehaviour {

    public GameObject leopar;
    float x, y, z;
    Vector3 pos;

    void Start()
    {
        x = Random.Range(-1.5f, 1.25f);
        y = Random.Range(-1.25f, 1.25f);
        z = 0f;
        
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }
    void Update()
    {
            
    }
}
