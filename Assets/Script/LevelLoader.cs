using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    private bool PlayerZone;
    //public string ScenetoLoad;
    public GameObject player;
	// Use this for initialization
	void Start () {
        PlayerZone = false;
        //var player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerZone == true)
        {
            SceneManager.LoadScene(2);
        }
        if(player == null)
        {

           Invoke("DelayedAction", 4);
        }
    }
    void DelayedAction()
    {
        SceneManager.LoadScene(4);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player1")
        {
            PlayerZone = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "player1")
        {
            PlayerZone = true;
        }
    }
}
