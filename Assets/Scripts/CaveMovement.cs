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
    // Start is called before the first frame update
    void Start()
    {
        xWalkingSpeed = 4;
        yWalkingSpeed = 4;  
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
       
    }
}
