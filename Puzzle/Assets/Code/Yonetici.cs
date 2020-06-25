using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yonetici : MonoBehaviour
{

    int yerlestirilen_parca = 0;
    int toplanan_puzzle = 20;
    public Text sonrakibolum_text;

   

    void Start()
    {
       
    }
    public void sayi_arttir()
    {
        yerlestirilen_parca++;
        if (yerlestirilen_parca == toplanan_puzzle)
        {
            sonrakibolum_text.text = "Sonraki Bölüme Geçiniz";
        }
    }
}
