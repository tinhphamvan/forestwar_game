using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALMoving_Real : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;

    

    //public float fireBallforce;
    
    // Use this for initialization
    void Start()
    {
        
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        //check reach patrol point
        if (Vector3.Distance(transform.position, currentPatrolPoint.position) < 1f)
        {
            if (currentPatrolIndex + 1 < patrolPoints.Length)
            {
                currentPatrolIndex++;
            }
            else
            {
                currentPatrolIndex = 0;
            }
            currentPatrolPoint = patrolPoints[currentPatrolIndex];
        }

        Vector3 patrolPointDir = currentPatrolPoint.position - transform.position;
        
        if(patrolPointDir.x < 0f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            
        }
        if (patrolPointDir.x > 0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
     
        }

       /*if (Time.time > lastAttackTime + attackDelay)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
            if(hit.transform == target)
            {
                GameObject newFireball = Instantiate(projectile, transform.position, transform.rotation);
                newFireball.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0f, fireBallforce));
                lastAttackTime = Time.time;
            }
        }*/
        
        

    }
}
