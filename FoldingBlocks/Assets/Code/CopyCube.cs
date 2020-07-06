using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyCube : MonoBehaviour
{
    public GameObject[] Object;
    GameObject instance;
    Vector3 vec;

	void Update ()
    {
        if (Input.GetKey("d"))
        {
            foreach (GameObject cube in Object)
            {
                instance = (GameObject)Instantiate(cube);
                instance.transform.position = transform.position + new Vector3(1, 0, 0);
                instance.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
        if (Input.GetKey("a"))
        {
            foreach (GameObject cube in Object)
            {
                instance = (GameObject)Instantiate(cube);
                instance.transform.position = transform.position + new Vector3(-1, 0, 0);
                instance.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
        if (Input.GetKey("w"))
        {
            foreach (GameObject cube in Object)
            {
                instance = (GameObject)Instantiate(cube);
                instance.transform.position = transform.position + new Vector3(0, 0, 1);
                instance.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
        if (Input.GetKey("s"))
        {
            foreach (GameObject cube in Object)
            {
                instance = (GameObject)Instantiate(cube);
                instance.transform.position = transform.position + new Vector3(0, 0, -1);
                instance.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }

    }

    void OnMouseDown()
    {
        
    }
}
