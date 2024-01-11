using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    public float PbulletSpeed;
    private Vector2 Mouse;

    // Start is called before the first frame update

    private void Awake()
    {
       
    }

    void Start()
    {
        
        

        // Update is called once per frame
        void Update()
        {
            Mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            p.bulletSpeed = ((Mouse - transform.position).normalized * 7);
            PbulletSpeed = Mouse - transform.position * Time.deltaTime;

        }
    }
}
