using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {
    //public Animator anim;
    public int hp = 1;
    //private int maxhp = .hp;
    public SimpleHealthBar healthBar;
    public SimpleHealthBar emergyBar;
    private Rigidbody2D rb;
    public int maxhp;
    /// <summary>
    /// Enemy or player?
    /// </summary>
    public bool isEnemy = true;
    public GameObject explosionParticles;
    public GameObject explosionParticles1;
    public GameObject explosionParticles2;
    /// <summary>
    /// Inflicts damage and check if the object should be destroyed
    /// </summary>
    /// <param name="damageCount"></param>
    void Start()
    {
        maxhp = hp;
        healthBar.UpdateBar(hp, maxhp);
        emergyBar.UpdateBar(hp, maxhp);
    }
   
    public void Damage(int damageCount)
    {
        hp -= damageCount;
        GameObject explo1 = (GameObject)Instantiate(explosionParticles1, transform.position, Quaternion.identity);

        Destroy(explo1, 0.4f);
        if (hp <= 0)
        {
           
            GameObject explo = (GameObject)Instantiate(explosionParticles, transform.position, Quaternion.identity);
           
            Destroy(explo, 5);
           
            SoundEffectsHelper.Instance.MakeExplosionSound();
           
            Destroy(gameObject);
        }
        healthBar.UpdateBar(hp, maxhp);
        emergyBar.UpdateBar(hp, maxhp);
    }
  
    public void BoostHealth(int health)
    {
        GameObject explo2 = (GameObject)Instantiate(explosionParticles2, transform.position, Quaternion.identity);

        Destroy(explo2, 0.4f);
        if (health >= maxhp - hp)
        {
            hp = maxhp;
        }
        else
        {
            hp += health;
        }
    }
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Is this a shot?
        ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
        if (shot != null)
        {
            
            // Avoid friendly fire
            if (shot.isEnemyShot != isEnemy)
            {
                
                Damage(shot.damage);

                // Destroy the shot
                Destroy(shot.gameObject); // Remember to always target the game object, otherwise you will just remove the script
            }
        }
        hhh s = otherCollider.gameObject.GetComponent<hhh>();
        if(s!= null && isEnemy == false)
        {
            BoostHealth(s.health);
            
            healthBar.UpdateBar(hp, maxhp);
            emergyBar.UpdateBar(hp, maxhp);
            Destroy(s.gameObject);
        }

    }
}
