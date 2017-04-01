using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Player))]
public class MoveObject2 : MonoBehaviour
{
    public Vector3 direction { get; set; }
    //public float speedX = 3;
    private Player player;
    public Rigidbody rb;
    private int healthP1 = 5;

    // Use this for initialization
    void Start()
    {
        //GetComponent<Rigidbody>().velocity = transform.up * speedX;
        player = GetComponent<Player>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Shot();
        Move();
           
    }

   void Move()
    {
        rb.velocity = direction;
    }

    int health1() {
        healthP1 -=1;
        return healthP1;
    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "mur")
        {
            Destroy(this.gameObject);
        }
        if (collider.gameObject.tag == "Player1")
        {
            health1();
            Debug.Log("P1 a " + healthP1 + " PV");
            Debug.Log("J'ai touché : " + collider.name);
            Destroy(this.gameObject);
            if (healthP1 <= 0)
            {
                Debug.Log("Player 2 won");
            }

        }
    }

}