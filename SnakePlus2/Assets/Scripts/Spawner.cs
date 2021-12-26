using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;
    public GameObject food;

    void OnTriggerEnter2D(Collider2D collideObj)
    {
        if (collideObj.gameObject.tag == "SnakeHead")
        {
            SpawnObjects();
            Destroy(food.gameObject);
        }
    }

    public void SpawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        BoxCollider2D c = quad.GetComponent<BoxCollider2D>();

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            Debug.Log(c.bounds.min.ToString());
            Debug.Log(c.bounds.max.ToString());
            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }
}
