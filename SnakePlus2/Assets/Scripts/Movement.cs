using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed = 5f;
    Vector2 _movement = Vector2.down;

    public void FixedUpdate()
    {
        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x) + _movement.x, Mathf.Round(this.transform.position.y) + _movement.y, 0.0f);
    }
    public void GoLeft()
    {
        if(_movement==Vector2.left)
        
            _movement = Vector2.up;
        else
        _movement = Vector2.left;
    }
    public void GoRight()
    {
        if (_movement == Vector2.right)

            _movement = Vector2.down;
        else
            _movement = Vector2.right;
    }
}
