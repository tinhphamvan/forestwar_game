using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Die : MonoBehaviour {
     //Collider nextBox;
    private GameObject[] a;
    private GameObject b;
    private GameObject c;
    
    // Use this for initialization
    void Start()
    {
        //a = GameObject.FindGameObjectsWithTag("Enemy");
        b = GameObject.FindGameObjectWithTag("Door");
        c = GameObject.FindGameObjectWithTag("Particle");
        b.GetComponent<Collider2D>().enabled = false;
        b.GetComponent<SpriteRenderer>().enabled = false;
        c.GetComponent<ParticleSystem>().enableEmission = false;
    }
    // Update is called once per frame
    void Update () {

        a = GameObject.FindGameObjectsWithTag("Enemy");
        if (a.Length == 0)
        {
            b.GetComponent<Collider2D>().enabled = true;
            b.GetComponent<SpriteRenderer>().enabled = true;
            c.GetComponent<ParticleSystem>().enableEmission = true;
        }
    }
}
