using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour {

    private Player player;
    private Vector3 velocity;

    private float maxVelocity = 0.3f;

	// Use this for initialization
	void Start () {
        player = GetComponent<Player>();
       
    }
	
	// Update is called once per frame
	void Update () {
        HandleVelocity();
        Move();
    }

    void HandleVelocity()
    {
        float xVelocity = 0;
        float zVelocity = 0;

        if (player.KeyDownPressed)
            zVelocity = maxVelocity;

        if (player.KeyUpPressed)
            zVelocity = -maxVelocity;


        if (player.KeyLeftPressed)
            xVelocity = maxVelocity;

        if (player.KeyRightPressed)
            xVelocity = -maxVelocity;

        velocity = new Vector3(xVelocity, 0, zVelocity);
    }


    void Move()
    {
        transform.Translate(velocity);
    }

    void OnTriggerEnter(Collider collider)
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("J'ai touché : " + collision.collider.name);
    }
}
