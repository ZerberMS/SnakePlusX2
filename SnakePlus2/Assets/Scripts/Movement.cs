using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private enum direction {
        right,down,left,up
    }
    direction _direction = direction.down;
    Dictionary<direction, Vector2> directionToMovement = new Dictionary<direction, Vector2>()
    {
        [direction.up] = Vector2.up,
        [direction.down] = Vector2.down,
        [direction.right] = Vector2.right,
        [direction.left] = Vector2.left,
    };
    public float MoveSpeed = 5f;

    public void FixedUpdate()
    {
        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x) + directionToMovement [_direction].x,
            Mathf.Round(this.transform.position.y) + directionToMovement [_direction].y, 0.0f);
    }
    public void GoLeft()
    {
        _direction--;
        if (_direction < 0)
        {
            _direction = (direction)3;
        }
    }
    public void GoRight()
    {
        _direction++;
        _direction = (direction)((int)_direction % 4);
    }
}
