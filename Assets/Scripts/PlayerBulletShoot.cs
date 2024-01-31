using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBulletShoot : MonoBehaviour
{
    public GameObject PlayerBullet;
    public PlayerBulletMovement bullet;

    public Cursorloc Cursorloc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            bullet = Instantiate(this.bullet, transform.position, UnityEngine.Quaternion.identity);
            bullet.PbulletSpeed = ((Cursorloc.mousePos - transform.position) * 12);
        }
    }
}
