﻿   using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class wall : MonoBehaviour {
    public GameObject[] bars;
    public GameObject[] labels;
    public string myGuiText;
    public int indx;
    float[] tas = new float[16] { 2.1f, 21.7f, 3.5f, 21.2f, 3.6f, 14.2f, 3.4f, 7.6f, 3.4f, 2.2f, 2.6f, 1.1f, 1.6f, 1.7f, 1.4f, 4.4f };
    // Use this for initialization
    void Start () {
        for (int i = 0; i < 16; i++)
        {
 
            Vector3 newpos = bars[i].transform.localScale;
            Vector3 textpos = bars[i].transform.localPosition;
            newpos.y += tas[i]/16; // Scale datapoint down to a reasonable size
            bars[i].transform.localScale = newpos;
            //now write a value above this bar
        
            myGuiText = "-----scene2------!";
            labels[i].GetComponent<TextMesh>().text = tas[i].ToString();
            textpos.y = textpos.y + newpos.y+3;
            textpos.x = textpos.x-1;
            labels[i].transform.localPosition = textpos;
            indx = i;
        }






    }
   

	// Update is called once per frame
	void Update () {
	
	}
}
