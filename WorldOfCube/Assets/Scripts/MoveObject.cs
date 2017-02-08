using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Player))]
public class MoveObject : MonoBehaviour {

    //public float speedX = 3;
    private Player player;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        //GetComponent<Rigidbody>().velocity = transform.up * speedX;
        player = GetComponent<Player>();
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        Shot();
    }

    void Shot ()
    {
        if (Input.GetButtonDown("Fire5"))
        {
              rb.velocity = new Vector3(-30, 0, 0);
        }

        if (Input.GetButtonDown("Fire6"))
        {
            rb.velocity = new Vector3(30, 0, 0);
        }

        if (Input.GetButtonDown("Fire7"))
        {
            rb.velocity = new Vector3(0, 0, -30);
        }

        if (Input.GetButtonDown("Fire8"))
        {
            rb.velocity = new Vector3(0, 0, 30);
        }

    }

}