using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    public Vector2 PbulletSpeed;
    private Vector2 Mouse;

    public Cursorloc Cursorloc;
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
        transform.Translate(PbulletSpeed * Time.deltaTime); 
    }
}
