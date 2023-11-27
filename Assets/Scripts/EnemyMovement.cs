using System;
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
            // radius up
            enemyAwarenessTime= enemyAwarenessTime- Time.deltaTime;
        }
        transform.Translate(enemySpeed*Time.deltaTime);
       
    }

    
        
    

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EnemyMoveSpeed = 3;
            target = other;
            enemySpeed = ((target.gameObject.transform.position - transform.position).normalized * EnemyMoveSpeed);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           target = null;
           enemyAwareness = true;
           enemySpeed = transform.position;
        }
            

    }
}
