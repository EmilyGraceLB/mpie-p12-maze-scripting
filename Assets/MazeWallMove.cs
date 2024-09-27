using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeWallMove : MonoBehaviour
{
    public float rotationSpeed = 50.0f;
    public float speed = 50.0f;
    public GameObject Maze;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

    
        Maze.transform.rotation = Quaternion.Euler(translation, rotation, 0);
    }
}
