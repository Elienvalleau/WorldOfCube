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
        Debug.Log(player.KeyLeftShotPressed);
        if (player.KeyLeftShotPressed)
            Debug.Log("OK left");
           /* rb.velocity = new Vector3(10, 0, 0);
        if (player.KeyRightShotPressed)
            rb.velocity = new Vector3(-10, 0, 0);
        if (player.KeyDownShotPressed)
            rb.velocity = new Vector3(0, 0, 10);
        if (player.KeyUpShotPressed)
            rb.velocity = new Vector3(0, 0, -10);
        if (Input.GetButtonDown("Fire1"))
            rb.velocity = new Vector3(0, 0, -10);*/
    }
}