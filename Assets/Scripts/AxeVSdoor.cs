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

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Alex") && Input.GetKeyDown(KeyCode.T))
        {
            Destroy(gameObject);
        }
    }
}       

