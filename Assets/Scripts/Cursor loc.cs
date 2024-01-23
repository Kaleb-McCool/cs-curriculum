using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursorloc : MonoBehaviour
{
    public Vector3 mousePos;
    public float moveSpeed = 0.001f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = Vector2.Lerp(transform.position, mousePos, moveSpeed);
    }
}
