using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour {
    public AudioSource sound;
    // Use this for initialization
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}
    
    public void Resume()
    {
        sound.Play();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Pause()
    {
        sound.Play();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void OptionMenu()
    {
        sound.Play();
       // Application.Quit();
    }

    public void QuitGame()
    {
        sound.Play();
        Application.Quit();
    }
}
