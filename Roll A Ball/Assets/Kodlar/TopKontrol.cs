using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public int sayi;

    int sayac = 0;
    public int ToplanacakObjeSayisi;
    public Text SayacText;
    public Text BittiText;

	void Start ()
    {
        fizik = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        float dikey = Input.GetAxisRaw("Vertical");
        float yatay = Input.GetAxisRaw("Horizontal");

        Vector3 vek = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vek * sayi);
    }

    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
        if(other.gameObject.tag == "engel")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);

            sayac++;
            SayacText.text = "Sayac = " + sayac;

            if (sayac == ToplanacakObjeSayisi)
            {
                BittiText.text = "OYUN BİTTİ";
            }
        }
    }
}
