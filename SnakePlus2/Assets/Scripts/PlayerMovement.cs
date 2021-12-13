using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject SnakeHead;

    // 1 is Up, 2 is Right, 3 is Down, 4 is Left.
    int moveDirection = 1;
    public float speed;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (moveDirection == 1)
        {
            SnakeHead.transform.position.y //Get, Set this thing!
        }
    }

    void Update()
    {
        
    }
}
