   using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class wall_ACT : MonoBehaviour {
    public GameObject[] bars;
    public GameObject[] labels;
    public string myGuiText;
    public int indx;
    float[] tas = new float[16] { 1.4f, 45.8f, 1.7f, 30.9f, 3.2f, 68.2f, 2.6f, 89.9f, 3.3f, 51f, 2.5f, 41.6f, 1.9f, 39.2f, 1.3f, 19.8f };
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
