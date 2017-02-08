using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {
    public GameObject pauseMenu;
    private bool isEnabled = false;

    void Update()
    {
        // Enable pause menu
        if (Input.GetKeyDown(KeyCode.Escape) && !isEnabled)
        {
            pauseMenu.SetActive(true);
            this.isEnabled = true;
            Time.timeScale = 0;
        }

        // disable pause menu
        else if (Input.GetKeyDown(KeyCode.Escape) && isEnabled)
        {
            pauseMenu.SetActive(false);
            this.isEnabled = false;
            Time.timeScale = 1;
        }
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        this.isEnabled = false;
        Time.timeScale = 1;
    }
}
