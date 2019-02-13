using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    //Collider nextBox;
    
    public GameObject a;
    private GameObject b;
    // Use this for initialization
    void Start()
    {
        //a = GameObject.FindGameObjectsWithTag("Enemy");
        b = GameObject.FindGameObjectWithTag("Die");
        
        //b.GetComponent<Collider2D>().enabled = false;
        b.GetComponent<SpriteRenderer>().enabled = false;
        //c.GetComponent<ParticleSystem>().enableEmission = false;
    }
    // Update is called once per frame
    void Update()
    {
       // a = GameObject.FindGameObjectWithTag("Enemy");
       // b = GameObject.FindGameObjectWithTag("Die");
        if (a == null)
        {
            //b.transform.localPosition = a.transform.localPosition;
            b.GetComponent<SpriteRenderer>().enabled = true;
            
        }
    }
}
