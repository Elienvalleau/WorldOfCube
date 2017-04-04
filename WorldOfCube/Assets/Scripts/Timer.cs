using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    private float x;
    private int timer;
    private string str;
   

	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        x += Time.deltaTime;
        timer = (int)x;
        str = timer.ToString();
        GameObject.Find("Timer").GetComponent<Text>().text = str;
	}
}
