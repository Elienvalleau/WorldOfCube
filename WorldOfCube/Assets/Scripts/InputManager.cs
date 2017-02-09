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
    public string LeftShotKeyP1;
    public string RightShotKeyP1;
    public string DownShotKeyP1;
    public string UpShotKeyP1;

    [Header("Player 2 Inputs")]
    public string LeftKeyP2;
    public string RightKeyP2;
    public string DownKeyP2;
    public string UpKeyP2;
    public string LeftShotKeyP2;
    public string RightShotKeyP2;
    public string DownShotKeyP2;
    public string UpShotKeyP2;

    private KeyCode 
        leftKeyCodeP1,
        rightKeyCodeP1,
        downKeyCodeP1,
        upKeyCodeP1,
        leftShotKeyCodeP1,
        rightShotKeyCodeP1,
        downShotKeyCodeP1,
        upShotKeyCodeP1;

    private KeyCode

        leftKeyCodeP2,
        rightKeyCodeP2,
        downKeyCodeP2,
        upKeyCodeP2,
        leftShotKeyCodeP2,
        rightShotKeyCodeP2,
        downShotKeyCodeP2,
        upShotKeyCodeP2;


    // Use this for initialization
    void Start ()
    {
        leftKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), LeftKeyP1);
        rightKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), RightKeyP1);
        downKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), DownKeyP1);
        upKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), UpKeyP1);
        leftShotKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), LeftShotKeyP1);
        rightShotKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), RightShotKeyP1);
        downShotKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), DownShotKeyP1);
        upShotKeyCodeP1 = (KeyCode)System.Enum.Parse(typeof(KeyCode), UpShotKeyP1);

        leftKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), LeftKeyP2);
        rightKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), RightKeyP2);
        downKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), DownKeyP2);
        upKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), UpKeyP2);
        leftShotKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), LeftShotKeyP2);
        rightShotKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), RightShotKeyP2);
        downShotKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), DownShotKeyP2);
        upShotKeyCodeP2 = (KeyCode)System.Enum.Parse(typeof(KeyCode), UpShotKeyP2);
    }
	
	// Update is called once per frame
	void Update ()
    {
        players[0].KeyLeftPressed = Input.GetKey(leftKeyCodeP1);
        players[0].KeyRightPressed = Input.GetKey(rightKeyCodeP1);
        players[0].KeyDownPressed = Input.GetKey(downKeyCodeP1);
        players[0].KeyUpPressed = Input.GetKey(upKeyCodeP1);
        players[0].KeyLeftShotPressed = Input.GetKey(leftShotKeyCodeP1);
        players[0].KeyRightShotPressed = Input.GetKey(rightShotKeyCodeP1);
        players[0].KeyDownShotPressed = Input.GetKey(downShotKeyCodeP1);
        players[0].KeyUpShotPressed = Input.GetKey(upShotKeyCodeP1);

        players[1].KeyLeftPressed = Input.GetKey(leftKeyCodeP2);
        players[1].KeyRightPressed = Input.GetKey(rightKeyCodeP2);
        players[1].KeyDownPressed = Input.GetKey(downKeyCodeP2);
        players[1].KeyUpPressed = Input.GetKey(upKeyCodeP2);
        players[1].KeyLeftShotPressed = Input.GetKey(leftShotKeyCodeP2);
        players[1].KeyRightShotPressed = Input.GetKey(rightShotKeyCodeP2);
        players[1].KeyDownShotPressed = Input.GetKey(downShotKeyCodeP2);
        players[1].KeyUpShotPressed = Input.GetKey(upShotKeyCodeP2);
    }
}
