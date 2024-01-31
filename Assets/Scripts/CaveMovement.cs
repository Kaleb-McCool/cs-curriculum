using System.Collections;
using System.Collections.Generic;
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

    private Scene scene;
    private Rigidbody2D rb;
    void Start()
    {
        xWalkingSpeed = 4;
        yWalkingSpeed = 4;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        string currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        if (currentScene == "OverWorld")
        {
            cave = false;
        }
        else
        {
            cave = false;
        }

        //if (cave)
        //{
            
        //}
        xDirection = Input.GetAxis("Horizontal");
        yDirection = Input.GetAxis("Vertical");
        xVector = xDirection * xWalkingSpeed * Time.deltaTime;
        yVector = yDirection * yWalkingSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, yVector, 0);

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * 5f, ForceMode.Force);
        }
    }
}
