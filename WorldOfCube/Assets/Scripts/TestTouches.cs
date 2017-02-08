using UnityEngine;
using System.Collections;

public class TestTouches : MonoBehaviour {

    private float horizontal = 0;
    private float vertical = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        GUI.Label(new Rect(10, 10, 150, 20), "Horizontal " + horizontal);
        GUI.Label(new Rect(10, 30, 150, 20), "Vertical " + vertical);

    }
}
