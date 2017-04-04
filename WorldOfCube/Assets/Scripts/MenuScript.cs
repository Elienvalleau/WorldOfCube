using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public void LoadLevel()
    { 
        Application.LoadLevel("jeu");
    }
    public void Quitter()
    {
        Application.Quit();
    }
}
