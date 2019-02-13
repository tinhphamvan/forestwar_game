using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victorymenu : MonoBehaviour
{
    public AudioSource sound;
    // Use this for initialization
    public void Back()
    {
        sound.Play();
        SceneManager.LoadScene(0);
    }   
    
}
