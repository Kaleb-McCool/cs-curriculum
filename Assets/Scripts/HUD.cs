using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    private static HUD gm;
    
    public int coins;
    public int health;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    
    
    void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health:" + health;
        coinText.text = "coins:" + coins;
    }
}
