using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RealCollisonScript : MonoBehaviour
{

    public GameObject player;
    float pos;
    float playerPos;
    public float direction;
    public float direction2;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("drill man");

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 blockPos = transform.position;
        pos = blockPos.x;
        pos = blockPos.y;

        Vector2 playerPosition = player.transform.position;
        playerPos = playerPosition.x;
        playerPos = playerPosition.y;


        if ((playerPosition.x <= blockPos.x + 1.5 && playerPosition.x >= blockPos.x - 1.5) && (playerPosition.y <= blockPos.y + 1.5 && playerPosition.y >= blockPos.y - 1.5))
        {
            direction = Input.GetAxisRaw("Horizontal");
            direction2 = Input.GetAxisRaw("Vertical");

            Vector3 collide = new Vector2(direction / 2, direction2 / 2);

            player.transform.position += collide * -1;
        }
        
    }


}
