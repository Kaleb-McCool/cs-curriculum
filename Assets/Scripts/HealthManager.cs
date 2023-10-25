using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour

{
    private HUD gm;
    public bool iFrames;
    private float timer;
    private float originalTimer;
    private int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<HUD>();
        originalTimer = .5f;
        timer = originalTimer;
        maxHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (iFrames)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                iFrames = false;
                timer = originalTimer;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            ChangeHealth(-3);
        }
        
        if (other.gameObject.CompareTag("HealingCross"))
        {
            gm.health = maxHealth;
        }
    }
    private void ChangeHealth(int amount)
    {
        if (!iFrames)
        {
            gm.health += amount;
            iFrames = true;
        }
    }


}
