using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturma : MonoBehaviour {
	public GameObject balon;

	float balonOlusturmaSuresi = 1f;
	float zamanSayacı = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		zamanSayacı -= Time.deltaTime;
		if (zamanSayacı < 0)
		{
			//zaman sayacı 0 altına düştüğünde balon olustur.
			//Instantiate (balon, new Vector3 (x, y, 0), Quaternion.Euler (0, 0, 0));
			GameObject go = Instantiate (balon, new Vector3 (Random.Range(-2.75f, 2.75f), -6f, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
			zamanSayacı = balonOlusturmaSuresi;

			//balon objesine hhareket etmesi için kuvvet uygulamamız lazım
			//new Vector3(0, Random.Range(30f, 80f), 0) --> Random.Range(30f, 80f) hız
			go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));
		}
		
	}
}
