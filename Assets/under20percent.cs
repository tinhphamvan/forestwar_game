using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class under20percent : MonoBehaviour {
    public GameObject Dark;
    public WeapongAIscript gun1;
    
    
    private ALMoving a;
    private HealthScript health;
    // Use this for initialization
    void Start () {
        a = GetComponent<ALMoving>();
        health = GetComponent<HealthScript>();
        gun1 = gun1.GetComponent<WeapongAIscript>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (health.hp < 100)
        {
            a.speed = 8;
            Dark.GetComponent<Renderer>().material.color = Color.red;
            
            gun1.shootingRate = 0.3f;
        }
	}
}
