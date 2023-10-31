using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretManager : MonoBehaviour
{
    public Collider2D target = null;
    private static turretManager TM;
    public GameObject bullet;
    public float FireCooldown;

    public float OrigFireCooldown;
    // Start is called before the first frame update
    void Start()
    {
        OrigFireCooldown = 3.0f;
        FireCooldown = OrigFireCooldown;
        
    }

    // Update is called once per frame
    void Update()
    {
        FireCooldown = FireCooldown - Time.deltaTime;
        if (target != null && FireCooldown <= 0)
        {
            
           var CR =  Instantiate(bullet, transform.position, Quaternion.identity);
           FireCooldown = OrigFireCooldown;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = other;
        }
    }
}
