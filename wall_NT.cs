   using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class wall_NT : MonoBehaviour {
    public GameObject[] bars;
    public GameObject[] labels;
    public string myGuiText;
    public int indx;
    float[] tas = new float[16] { 0.8f, 15.2f, 1.5f, 23.8f, 0.8f, 26.6f, 0.5f, 32.5f, 1f, 33.6f, 1.8f, 40.3f, 1.4f, 35.4f, 1f, 32.7f };
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
