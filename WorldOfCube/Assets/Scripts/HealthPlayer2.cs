using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthPlayer2 : MonoBehaviour {

    public Slider healthBarSlider;
    public Text player;
    private bool win = false;

	// Use this for initialization
	void Start () {
        player.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "projectile" && healthBarSlider.value>0)
        {
            healthBarSlider.value -= .25f;
        }
        if (healthBarSlider.value == 0)
        {
            win = true;
            player.enabled = true;
            Time.timeScale = 0;
        }
    }
}