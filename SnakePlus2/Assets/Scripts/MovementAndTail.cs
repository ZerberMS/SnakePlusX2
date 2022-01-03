using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAndTail : MonoBehaviour
{
    private List<Transform> segments; //keeps track of the segments' positions
    public Transform segmentPrefab;

    private enum direction {right,down,left,up}
    direction _direction = direction.down;
    public float moveSpeed;
    Dictionary<direction, Vector2> directionToMovement = new Dictionary<direction, Vector2>()
    {
        [direction.up] = Vector2.up,
        [direction.down] = Vector2.down,
        [direction.right] = Vector2.right,
        [direction.left] = Vector2.left,
    };


    private void Start()
    {
        segments = new List<Transform>();
        segments.Add(this.transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Grow();
            Grow();
            Grow();
            Grow();
            Grow();
        }
    }

    private void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = segments[segments.Count - 1].position;
        segments.Add(segment);
    }


    public void FixedUpdate()
    {
        for (int i = segments.Count - 1; i > 0; i--)
        {
            segments[i].position = segments[i - 1].position;
        }

        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x) + (directionToMovement [_direction].x) * moveSpeed,
            Mathf.Round(this.transform.position.y) + (directionToMovement [_direction].y) * moveSpeed, 0.0f);
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
