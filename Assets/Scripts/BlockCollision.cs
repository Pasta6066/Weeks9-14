using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCollision : MonoBehaviour
{

    public GameObject block;
    public int rows = 6;
    public int columns  = 7;
    public float spacing = 1.5f;
    public Vector2 startPoint = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        gridSpawner();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void gridSpawner()
    {
        for (int i = 0;  i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Vector2 spawnPosition = new Vector2(startPoint.x + (j * spacing), startPoint.y + (i * spacing));
                Instantiate(block, spawnPosition, Quaternion.identity);
            }
        }
    }
}
