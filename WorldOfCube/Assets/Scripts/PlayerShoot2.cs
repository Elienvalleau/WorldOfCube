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

        bool leftFired = false;
        bool rightFired = false;
        bool upFired = false;
        bool downFired = false;

        rightFired = Input.GetButtonDown("Fire1");
        leftFired = Input.GetButtonDown("Fire2");
        upFired = Input.GetButtonDown("Fire3");
        downFired = Input.GetButtonDown("Fire4");

        if (rightFired || leftFired || upFired || downFired)
        {
            if (compteur <= 0)
            {
                //shotPosition.x = this.gameObject.transform.position.x;
                //shotPosition.y = this.gameObject.transform.position.y;
                //shotPosition.z = this.gameObject.transform.position.z;

                switch (typeShot)
                {
                    case 1:
                        GameObject instance = (GameObject)GameObject.Instantiate(shot, transform.position, this.gameObject.transform.rotation);
                        instance.name = shot.name;

                        Vector3 direction = new Vector3();

                        if (rightFired)
                            direction = new Vector3(-30, 0, 0);

                        else if (leftFired)
                            direction = new Vector3(30, 0, 0);

                        else if (upFired)
                            direction = new Vector3(0, 0, -30);

                        else direction = new Vector3(0, 0, 30);

                        instance.GetComponent<MoveObject2>().direction = direction;


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