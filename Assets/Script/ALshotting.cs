using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALshotting : MonoBehaviour
{
    // public Rigidbody2D r2;

    private Transform player;
    private GameObject player1;
    public Vector2 speed = new Vector2(10, 10);

    //public float speed;
    private Vector2 movement;
    public Vector2 direction = new Vector2(10, 10);
    private Rigidbody2D rigidbodyComponent;

    void Start()
    {

        player1 = GameObject.FindGameObjectWithTag("Player");
        if (player1 == null)
        {

        }
        else
        {
            player = player1.transform;
            direction = new Vector2(player.position.x, player.position.y);
        }



    }
    void Update()
    {
       
        //
        // direction = new Vector2(player.transform.position.x, player.transform.position.y);
        //direction = new Vector2(player.position.x, player.position.y);
        //transform.position = Vector2.MoveTowards(transform.position, direction, 3 * Time.deltaTime);

        // direction = new Vector2(player.position.x, player.position.y);
        movement = new Vector2(
         speed.x * direction.x,
         speed.y * direction.y);
        //transform.position = Vector2.MoveTowards(transform.position, direction, 3 * Time.deltaTime);
        // = movement;

        //movement = this.transform.position;

        /*     if(transform.position.x == target.x && transform.position.y == target.y)
         {
             DestroyProjectile();
         }*/
    }
    void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // Apply movement to the rigidbody
        rigidbodyComponent.velocity = movement;
    }


}
