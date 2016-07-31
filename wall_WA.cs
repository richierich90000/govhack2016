   using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class wall_WA : MonoBehaviour {
    public GameObject[] bars;
    public GameObject[] labels;
    public string myGuiText;
    public int indx;
    float[] tas = new float[16] { 1.4f, 55.9f, 2.5f, 85.9f, 3.2f, 97.3f, 3.5f, 100.1f, 3.3f, 90.7f, 2.6f, 87.8f, 1.5f, 70.9f, 1.7f, 62.8f };
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
