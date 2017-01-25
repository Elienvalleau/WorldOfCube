using UnityEngine;
using System.Collections;

public class SpawnerPlayer : MonoBehaviour {
    public Transform player;
    public float coordx;
    public float coordz;

    // Use this for initialization
    void Start () {
        GameObject instance = (GameObject)Instantiate(player, new Vector3(coordx, 7, coordz), Quaternion.identity);
        instance.name = player.name;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}