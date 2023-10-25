using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretManager : MonoBehaviour
{
    public Collider2D target = null;
    private static turretManager TM;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Instantiate(bullet, new Vector3(1, 0, 0 ), Quaternion.identity);
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
