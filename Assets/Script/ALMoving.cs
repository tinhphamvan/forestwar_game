using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALMoving : MonoBehaviour {
	public Transform[] patrolPoints;
	public float speed;
	Transform currentPatrolPoint;
	int currentPatrolIndex;
    private Rigidbody2D m_Rigidbody2D;

    // Use this for initialization
    void Start () {
		currentPatrolIndex = 0;
		currentPatrolPoint = patrolPoints[currentPatrolIndex];
	}
	
	// Update is called once per frame
	void Update () {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();

        transform.Translate (Vector3.up * Time.deltaTime * speed);
		//check reach patrol point
		if(Vector3.Distance(transform.position, currentPatrolPoint.position) < .1f)
		{
			if(currentPatrolIndex + 1 < patrolPoints.Length){
				currentPatrolIndex ++;
			}
			else{
				currentPatrolIndex = 0;
			}
			currentPatrolPoint = patrolPoints[currentPatrolIndex];
		}
        
        Vector3 patrolPointDir = currentPatrolPoint.position - transform.position;
        float angle = Mathf.Atan2(patrolPointDir.y, patrolPointDir.x) * Mathf.Rad2Deg - 90f;

        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 90f);
        // transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 90f);

        //m_Rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }	
}
