using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader3 : MonoBehaviour
{
    private bool PlayerZone;
    //public string ScenetoLoad;
    public GameObject player;
    public GameObject enemy;
    // Use this for initialization
   

    // Update is called once per frame
    void Update()
    {
        
        if (player == null)
        {

            Invoke("DelayedAction1", 4);
        }
        if (enemy == null)
        {
            Invoke("DelayedAction", 4);
        }
       
    }
    void DelayedAction()
    {
        SceneManager.LoadScene(6);
    }
    void DelayedAction1()
    {
        SceneManager.LoadScene(5);
    }

}
