using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    private Vector3 velocity;
<<<<<<< HEAD

    [SerializeField]
    private float maxVelocity = 15f;
    [SerializeField]
    private float moveForce = 110f;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
=======
    
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
>>>>>>> master
        float xVelocity = 0;
        float zVelocity = 0;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float rbVelocityX = rb.velocity.x;
        float rbVelocityZ = rb.velocity.z;
        Vector3 rbVelocity = rb.velocity;


        if (horizontal != 0 && rbVelocityX < maxVelocity && rbVelocityX > -maxVelocity)
        {
            if ((horizontal > 0 && rbVelocityX < 0) || (horizontal < 0 && rbVelocityX > 0))
            {
                rbVelocity.x = 0;
                rb.velocity = rbVelocity;
            }
            xVelocity = moveForce * horizontal;
        } else if (horizontal == 0)
        {
            rbVelocity.x = 0;
            rb.velocity = rbVelocity;
        }

        if(vertical != 0 && rbVelocityZ < maxVelocity && rbVelocityZ > -maxVelocity)
        {
            if ((vertical > 0 && rbVelocityZ < 0) || (vertical < 0 && rbVelocityZ > 0))
            {
                rbVelocity.z = 0;
                rb.velocity = rbVelocity;
            }
            zVelocity = moveForce * vertical;
        } else if (vertical == 0)
        {
            rbVelocity.z = 0;
            rb.velocity = rbVelocity;
        }


        velocity = new Vector3(xVelocity, 0, zVelocity);
        rb.AddForce(velocity, ForceMode.Acceleration);
    }

//  void OnGUI()
//  {
//      float rbVelocityX = rb.velocity.x;
//      float rbVelocityZ = rb.velocity.z;
//      float horizontal = Input.GetAxis("Horizontal");
//      float vertical = Input.GetAxis("Vertical");
//      GUI.Label(new Rect(10, 10, 150, 20), "Horizontal " + horizontal);
//      GUI.Label(new Rect(10, 30, 150, 20), "Vertical " + vertical);
//      GUI.Label(new Rect(10, 40, 150, 20), "rbVelocityX " + rbVelocityX);
//      GUI.Label(new Rect(10, 50, 150, 20), "rbVelocityZ " + rbVelocityZ);
//  }
}
