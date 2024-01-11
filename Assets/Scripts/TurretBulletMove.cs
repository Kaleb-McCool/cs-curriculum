using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

public class TurretBulletMove : MonoBehaviour
{
    public Vector2 bulletSpeed;
    

    void Update()
    {
        transform.Translate(bulletSpeed*Time.deltaTime);
       
      
    }
}
   
