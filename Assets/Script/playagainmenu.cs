using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playagainmenu : MonoBehaviour
{
    public AudioSource sound;
    // Use this for initialization
    public void PlayAgain()
    {
        sound.Play();
        SceneManager.LoadScene(1);
    }
    public void BackMenu()
    {
        sound.Play();
        SceneManager.LoadScene(0);
    }
}
