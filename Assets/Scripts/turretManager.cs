using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class turretManager : MonoBehaviour
{
    public TurretBulletMove bulletPrefab;
    public Collider2D target = null;
    public GameObject bullet;
    public float FireCooldown;
    public float OrigFireCooldown;
    public bool Active;
    // Start is called before the first frame update
    void Start()
    {
        Active = false;
        OrigFireCooldown = 3.0f;
        FireCooldown = OrigFireCooldown;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Active == true)
        {
             FireCooldown = FireCooldown - Time.deltaTime;
                    if (target != null && FireCooldown <= 0)
                    { 
                        FireCooldown = OrigFireCooldown;
                       TurretBulletMove p =  Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                       p.bulletSpeed = ((target.gameObject.transform.position - transform.position).normalized * 7);
            
                    }
        }
       
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = null;
            Active = false;
            FireCooldown = OrigFireCooldown;
        }
            

    }
}
