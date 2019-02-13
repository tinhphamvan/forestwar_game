using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alAutoshot : MonoBehaviour {

    // Use this for initialization
    private WeapongAIscript[] weapons;

    void Awake()
    {
        // Retrieve the weapon only once
        weapons = GetComponentsInChildren<WeapongAIscript>();
    }

    void Update()
    {
        foreach (WeapongAIscript weapon in weapons)
        {
            // Auto-fire
            if (weapon != null && weapon.CanAttack)
            {
                weapon.Attack(true);
                SoundEffectsHelper.Instance.MakeEnemyShotSound();
            }
        }
    }
}
