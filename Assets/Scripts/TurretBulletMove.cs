using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TurretBulletMove : MonoBehaviour
{
    private Vector3 initialPlayerPosition; // Initial position of the player when the bullet is created
    public float speed = 10.0f; // The speed at which the bullet moves

    // This function is called when you instantiate the bullet
    public void Initialize(Vector3 playerPosition)
    {
        initialPlayerPosition = playerPosition;
    }

    void Update()
    {
        // Calculate the direction from the bullet to the initial player position
        Vector3 direction = initialPlayerPosition - transform.position;

        // Use Vector2.MoveTowards to move the bullet towards the initial player position
        Vector3 newPosition = Vector2.MoveTowards(transform.position, initialPlayerPosition, speed * Time.deltaTime);

        // Update the bullet's position
        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
    }
}
   
