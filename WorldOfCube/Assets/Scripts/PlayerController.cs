using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour {

    private Player player;
    private Vector3 velocity;
    public GameObject Bullet_Emitter;
    public GameObject Bullet;
    //GameObject prefab;


    private float maxVelocity = 0.3f;

	// Use this for initialization
	void Start () {
        player = GetComponent<Player>();
        //prefab = Resources.Load("Cube") as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
        HandleVelocity();
        Tir();
        Move();
    }

    void HandleVelocity()
    {
        float xVelocity = 0;
        float zVelocity = 0;

        if (player.KeyDownPressed)
        {
            
            zVelocity = maxVelocity;
        }
            

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

    
    void Tir()
    {
        Rigidbody Temporary_RigidBody;
        GameObject Temporary_Bullet_Handler;
        if (player.KeyDownTirPressed)
        {
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position/**new Vector3(1,0,0)**/, Bullet_Emitter.transform.rotation) as GameObject;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            Destroy(Temporary_Bullet_Handler, 1.0f);
            //GameObject Cube = Instantiate(prefab) as GameObject;

        }
            
        if (player.KeyUpTirPressed)
        {
            Temporary_Bullet_Handler = Instantiate(Bullet, new Vector3(0, 0, 0), Bullet_Emitter.transform.rotation) as GameObject;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            Destroy(Temporary_Bullet_Handler, 1.0f);
        }
        
        if (player.KeyLeftTirPressed)
        {
            Temporary_Bullet_Handler = Instantiate(Bullet, new Vector3(0, 0, 0), Bullet_Emitter.transform.rotation) as GameObject;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            Destroy(Temporary_Bullet_Handler, 1.0f);
        }
            
        if (player.KeyRightTirPressed)
        {
            Temporary_Bullet_Handler = Instantiate(Bullet, new Vector3(0, 0, 0), Bullet_Emitter.transform.rotation) as GameObject;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            Destroy(Temporary_Bullet_Handler, 1.0f);
        }
            
    }
}
