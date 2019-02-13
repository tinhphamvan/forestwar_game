using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class optionmenu : MonoBehaviour {
    public AudioSource sound;
    public AudioMixer audioMixer;
    
    
    // Use this for initialization
    public void PlayGame()
    {
        sound.Play();
        
        
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

}
