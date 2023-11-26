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
        //Mouses position in the "real world"? EDIT: The "Real World" is the games coordinate plane where as originaly it is the pixel location
       //Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       //mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
       //transform.position = mousePosition;
      
    }
}
   
