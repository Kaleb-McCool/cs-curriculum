using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AxeVSdoor : MonoBehaviour
{
    public bool axehas;
    // Start is called before the first frame update
    void Start()
    {
        axehas = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("here");
    }
}       

