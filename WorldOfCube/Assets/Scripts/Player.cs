using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    [Header("Player Settings")]
    public int MaxHealth;
    [HideInInspector]
    public int CurrentHealth;

    public bool KeyLeftPressed { get; set; }
    public bool KeyRightPressed { get; set; }
    public bool KeyDownPressed { get; set; }
    public bool KeyUpPressed { get; set; }

    void Start () {
        CurrentHealth = MaxHealth;
	}

	void Update () {

    }
}
