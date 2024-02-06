using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update

    private void Awake()
    {
       
    }

    void Start()
    {
        
        

       
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        direction.z = 0;
        direction.Normalize();
        transform.Translate(direction * speed * Time.deltaTime); 
    }
}
