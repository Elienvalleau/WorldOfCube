using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputManager : MonoBehaviour {

    [Header("Players List")]
    public List<Player> players;
    

    [Header("Player 1 Inputs")]
    public string LeftKeyP1;
    public string RightKeyP1;
    public string DownKeyP1;
    public string UpKeyP1;

    [Header("Player 2 Inputs")]
    public string LeftKeyP2;
    public string RightKeyP2;
    public string DownKeyP2;
    public string UpKeyP2;

    private KeyCode 
        leftKeyCodeP1,
        rightKeyCodeP1,
        downKeyCodeP1,
        upKeyCodeP1;

    private KeyCode
     leftKeyCodeP2,
     rightKeyCodeP2,
     downKeyCodeP2,
     upKeyCodeP2;


    // Use this for initialization
    void Start ()
    {

        leftKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), LeftKeyP1);
        rightKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), RightKeyP1);
        downKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), DownKeyP1);
        upKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), UpKeyP1);

        leftKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), LeftKeyP2);
        rightKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), RightKeyP2);
        downKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), DownKeyP2);
        upKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), UpKeyP2);
    }
	
	// Update is called once per frame
	void Update ()
    {
        players[0].KeyLeftPressed = Input.GetKey(leftKeyCodeP1);
        players[0].KeyRightPressed = Input.GetKey(rightKeyCodeP1);
        players[0].KeyDownPressed = Input.GetKey(downKeyCodeP1);
        players[0].KeyUpPressed = Input.GetKey(upKeyCodeP1);

        players[1].KeyLeftPressed = Input.GetKey(leftKeyCodeP2);
        players[1].KeyRightPressed = Input.GetKey(rightKeyCodeP2);
        players[1].KeyDownPressed = Input.GetKey(downKeyCodeP2);
        players[1].KeyUpPressed = Input.GetKey(upKeyCodeP2);
    }
}
