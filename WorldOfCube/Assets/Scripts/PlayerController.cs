using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour {

    private Player player;
    private Vector3 velocity;

    [SerializeField]
    private float maxVelocity = 10f;
    [SerializeField]
    private float moveForce = 50f;

	// Use this for initialization
	void Start () {
        player = GetComponent<Player>();
       
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        HandleVelocity();
        Move();
    }

    void HandleVelocity()
    {
        float xVelocity = 0;
        float zVelocity = 0;
        Vector3 speed = GetComponent<Rigidbody>().velocity;

        if (player.KeyDownPressed && speed.z < maxVelocity)
            zVelocity = moveForce;

        if (player.KeyUpPressed && speed.z > -maxVelocity)
            zVelocity = -moveForce;

        if (player.KeyLeftPressed && speed.x < maxVelocity)
            xVelocity = moveForce;

        if (player.KeyRightPressed && speed.x > -maxVelocity)
            xVelocity = -moveForce;

        velocity = new Vector3(xVelocity, 0, zVelocity);
    }


    void Move()
    {
        GetComponent<Rigidbody>().AddForce(velocity, ForceMode.Acceleration);
    }
}
