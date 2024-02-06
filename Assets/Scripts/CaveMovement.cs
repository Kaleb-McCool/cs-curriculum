using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveMovement : MonoBehaviour
{
    public bool cave;
    public float xWalkingSpeed;
    public float yWalkingSpeed;
    public float xDirection;
    public float yDirection;
    public float xVector;
    public float yVector;
    public int jumpcont;
    public GameObject axe;
    public bool axehave;

    private Scene scene;
    private Rigidbody2D rb;
    public bool onground = false;
    void Start()
    {
        xWalkingSpeed = 4;
        yWalkingSpeed = 4;
        rb = GetComponent<Rigidbody2D>();
        jumpcont = 1;
        string currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        if (currentScene == "OverWorld")
        {
            yWalkingSpeed = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        onground = Physics2D.Raycast(transform.position, Vector2.down, 1f, LayerMask.GetMask("Ground"));
        if (onground)
        {
            jumpcont = 1;
        }



        xDirection = Input.GetAxis("Horizontal");
            yDirection = Input.GetAxis("Vertical");
            xVector = xDirection * xWalkingSpeed * Time.deltaTime;
            yVector = yDirection * yWalkingSpeed * Time.deltaTime;
            transform.position = transform.position + new Vector3(xVector, yVector, 0);
            if (Input.GetKey(KeyCode.Space) && jumpcont == 1)
            {
                rb.AddForce(transform.up * 10f);
                jumpcont--;
            }

            if (Input.GetKey(KeyCode.O) && axehave &&)
            {
                Instantiate(axe, transform.position, quaternion.identity);
            }
    }

   

