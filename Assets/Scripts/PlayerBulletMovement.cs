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
        PbulletSpeed = 5.0f;
        

        // Update is called once per frame
        void Update()
        {
            Mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = Vector2.MoveTowards(transform.position, Mouse, PbulletSpeed * Time.deltaTime);

        }
    }
}
