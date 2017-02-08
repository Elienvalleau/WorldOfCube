using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Player))]
public class MoveObject2 : MonoBehaviour
{
    public Vector3 direction { get; set; }
    //public float speedX = 3;
    private Player player;
    public Rigidbody rb;

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
}