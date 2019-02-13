using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump1 = false;
    public Animator anim;

    // Use this for initialization

    
	// Update is called once per frame
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        if (Input.GetButtonUp("Jump")){
            jump1 = true;
            anim.SetBool("isJumping", true);
        }
        
        bool shoot = Input.GetButtonDown("Fire1");
 
        // Careful: For Mac users, ctrl + arrow is a bad idea
        if (Input.GetButtonUp("Jump") && Input.GetButtonDown("Fire1"))
        {
            jump1 = true;
            shoot = Input.GetButtonDown("Fire1");
        }
        if (shoot)
        {
            WeaponScript weapon = GetComponent<WeaponScript>();
            if (weapon != null)
            {
                // false because the player is not an enemy
                weapon.Attack(false);
                SoundEffectsHelper.Instance.MakePlayerShotSound();
            }
        }
    }
    public void OnLanding ()
    {
        anim.SetBool("isJumping", false);
    }
    void FixedUpdate()
    {
       controller.Move(horizontalMove* Time.fixedDeltaTime, false,jump1);
       jump1 = false;
    }
}
