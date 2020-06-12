using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DortIslem  : MonoBehaviour {

	public UnityEngine.UI.Text ilkSayi;
	public UnityEngine.UI.Text ikinciSayi;
	public UnityEngine.UI.Text islem;
	public UnityEngine.UI.Text Sonuc;
	public UnityEngine.UI.Text Cevap;
	public UnityEngine.UI.InputField Sonucinput;
	int sayi1, sayi2, islemisareti;
	int islemSonucu;

	// Use this for initialization
	void Start () 
	{
		YeniSoru ();
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	public void CevapKontrolu()
	{
		if (int.Parse (Cevap.text) == islemSonucu) {
			Sonuc.text = "DOGRU";
		}
		else 
		{
			Sonuc.text = "YANLIS";
		}
	}

	public void YeniSoru()
	{
		Sonuc.text = "";
		Sonucinput.text = "";

		sayi1 = Random.Range (1, 10);
		sayi2 = Random.Range (1, 10);
		islemisareti = Random.Range (1, 4);

		switch (islemisareti) 
		{
		case 1:
			islem.text = "+";
			islemSonucu = sayi1 + sayi2;
			break;
		case 2:
			islem.text = "-";
			islemSonucu = sayi1 - sayi2;
			break;
		case 3:
			islem.text = "*";
			islemSonucu = sayi1 * sayi2;
			break;
		case 4:
			islem.text = "/";
			islemSonucu = sayi1 / sayi2;
			break;
		}

		ilkSayi.text = sayi1 + "";
		ikinciSayi.text = sayi2 + "";
	}

}
