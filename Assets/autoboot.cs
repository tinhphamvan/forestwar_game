using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class autoboot : MonoBehaviour
{

    private shotheathscript[] weapons;

    void Awake()
    {
        // Retrieve the weapon only once
        weapons = GetComponentsInChildren<shotheathscript>();
    }

    void Update()
    {
        foreach (shotheathscript weapon in weapons)
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


