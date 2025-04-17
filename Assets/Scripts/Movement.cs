using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    SpriteRenderer sr;
    public float speed = 2;
    public float direction;
    public float direction2;




    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        direction2 = Input.GetAxisRaw("Vertical");

        sr.flipX = (direction < 0);
        

        transform.position += transform.right * direction * speed * Time.deltaTime;
        transform.position += transform.up * direction2 * speed * Time.deltaTime;



    }





}
