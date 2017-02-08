using UnityEngine;
using System.Collections;

public class PlayerShoot2 : MonoBehaviour
{

    private Player player;
    //public Rigidbody rb;
    public GameObject shot;
    public int coolDown = 0;

    private int typeShot = 1;
    private Vector3 shotPosition;
    private GameObject forGround;
    private int compteur = 0;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<Player>();
        forGround = GameObject.FindGameObjectWithTag("ForGround");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*Debug.Log(GetComponent<Player>().KeyLeftShotPressed);*/
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire3") || Input.GetButtonDown("Fire4"))
        {
            if (compteur <= 0)
            {
                shotPosition.x = this.gameObject.transform.position.x;
                shotPosition.y = this.gameObject.transform.position.y;
                shotPosition.z = this.gameObject.transform.position.z;

                switch (typeShot)
                {
                    case 1:
                        GameObject instance = (GameObject)GameObject.Instantiate(shot, transform.position, this.gameObject.transform.rotation);
                        instance.name = shot.name;

                        //if (Input.GetButtonDown("Fire1"))
                        //  Debug.Log("OK left2");

                        //instance.transform.parent = forGround.transform.parent;
                        break;
                    case 2:
                    default:

                        break;
                }
                compteur = coolDown;
            }
        }
        compteur -= 1;

    }
}