using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {
    public AudioSource sound;
   
    // Use this for initialization
    public void PlayGame()
    {
        sound.Play();
       // loadingImage.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        sound.Play();
        Application.Quit();
    }
}
