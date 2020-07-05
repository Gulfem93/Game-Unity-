using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text SureText;
    float Sure = 0;

	void Update ()
    {
        Sure += Time.deltaTime;
        SureText.text = "Score: " + (int)Sure;
	}
}
