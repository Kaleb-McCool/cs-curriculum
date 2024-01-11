using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBulletShoot : MonoBehaviour
{
    public GameObject PlayerBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(PlayerBullet, transform.position, Quaternion.identity);
        }
    }
}
