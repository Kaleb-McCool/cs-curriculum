using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Collider2D target = null;
    public bool FollowActive;
    public bool enemyAwareness;
    public float MaxEnemyAwarenessTime;
    public float enemyAwarenessTime;
    public Vector2 enemySpeed;

    public float EnemyMoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        EnemyMoveSpeed = 3;
        FollowActive = false;
        MaxEnemyAwarenessTime = 30.0f;
        enemyAwarenessTime = MaxEnemyAwarenessTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyAwareness == true)
        {
            enemyAwarenessTime= enemyAwarenessTime- Time.deltaTime;
        }
        transform.Translate(enemySpeed*Time.deltaTime);
        if (FollowActive == true)
        {
            if (target != null)
            { 
                enemySpeed = ((target.gameObject.transform.position - transform.position).normalized * EnemyMoveSpeed);
            
            }
        }
       
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = other;
            FollowActive = true;
            EnemyMoveSpeed = 3;
        }
        
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = null;
            FollowActive = false;
            enemyAwareness = true;
            EnemyMoveSpeed = -Time.deltaTime;
        }
            

    }
}
