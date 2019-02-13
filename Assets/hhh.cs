using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hhh : MonoBehaviour {
    
	// Use this for initialization
	
    public int health = 10;

    /// <summary>
    /// Projectile damage player or enemies?
    /// </summary>
    
    void Start()
    {
        Destroy(gameObject, 10);
    }
}
