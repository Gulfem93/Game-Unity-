using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eslestirme : MonoBehaviour
{
    Camera kamera;
    GameObject[] golgeler;
    Vector2 baslangic_posizyonu;

    Yonetici yonet;

	void Start ()
    {
        kamera = GameObject.Find("Camera").GetComponent<Camera>();
        golgeler = GameObject.FindGameObjectsWithTag("zemin");
        baslangic_posizyonu = transform.position;

        yonet = GameObject.Find("Yonetici").GetComponent<Yonetici>();
	}
	
	void Update ()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject golge in golgeler)
            {
                if(gameObject.name == golge.name)
                {
                    float mesafe = Vector3.Distance(golge.transform.position, transform.position);

                    if (mesafe <= 1)
                    {
                        transform.position = golge.transform.position;
                        yonet.sayi_arttir();
                        this.enabled = false;
                        Destroy(this);
                    }
                    else
                    {
                        transform.position = baslangic_posizyonu;
                    }
                }
            }
        }
	}

    void OnMouseDrag()
    {
        Vector3 posizyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        posizyon.z = 0;
        transform.position = posizyon;
    }

}
