using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Player))]
public class MoveObject : MonoBehaviour
{
    public Vector3 direction { get; set; }
    //public float speedX = 3;
    private Player player;
    public Rigidbody rb;
    public int healthP2 = 5;

	// Use this for initialization
	void Start ()
    {
        //GetComponent<Rigidbody>().velocity = transform.up * speedX;
        player = GetComponent<Player>();
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Shot();
        Move();
    }

    void Move()
    {
        rb.velocity = direction;
    }

    int health2()
    {
        healthP2 -= 1;
        return healthP2;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "mur")
        {
            Destroy(this.gameObject);
        }
        if (collider.gameObject.tag == "Player2")
        {
            health2();
            Debug.Log("P2 a " + healthP2 + " PV");
            Debug.Log("J'ai touché : " + collider.name);
            Destroy(this.gameObject);
            if (healthP2<=0)
            {
                Debug.Log("Player 1 won");
            }
        }
    }

}