using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RealCollisonScript : MonoBehaviour
{

    public GameObject player;
    public float direction;
    public float direction2;

    public GameObject hitbox;

    public GameObject self;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("drill man");
        hitbox = GameObject.Find("mineHitbox");
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector2 blockPos = transform.position;


        Vector2 playerPosition = player.transform.position;



        if ((playerPosition.x <= blockPos.x + 3 && playerPosition.x >= blockPos.x - 3) && (playerPosition.y <= blockPos.y + 3 && playerPosition.y >= blockPos.y - 3))
        {
            direction = Input.GetAxisRaw("Horizontal");
            direction2 = Input.GetAxisRaw("Vertical");

            Vector3 collide = new Vector2(direction / 2, direction2 / 2);

            player.transform.position += collide * -1;
        }

        

    }

    public void blockBreak()
    {
        Vector2 blockPos = transform.position;

        hitbox = GameObject.Find("mineHitbox");
        self = GameObject.Find("dirt block");

        Vector2 hitboxPosition = hitbox.transform.position;
        if ((hitboxPosition.x <= blockPos.x + 3 && hitboxPosition.x >= blockPos.x - 3) && (hitboxPosition.y <= blockPos.y + 3 && hitboxPosition.y >= blockPos.y - 3))
        {
            Destroy(self);
            Debug.Log("Block Broken Real");
        }
    }


}
