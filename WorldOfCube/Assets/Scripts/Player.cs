using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    [Header("Player Settings")]
    public int MaxHealth = 3;
    [HideInInspector]
    public int CurrentHealth;

    public bool KeyLeftPressed { get; set; }
    public bool KeyRightPressed { get; set; }
    public bool KeyDownPressed { get; set; }
    public bool KeyUpPressed { get; set; }
    public bool KeyLeftShotPressed { get; set; }
    public bool KeyRightShotPressed { get; set; }
    public bool KeyDownShotPressed { get; set; }
    public bool KeyUpShotPressed { get; set; }

    void Start () {
        CurrentHealth = MaxHealth;
	}


    void Update () {

    }
}
