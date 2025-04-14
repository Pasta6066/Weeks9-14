using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public GameObject mineHitbox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(mine());
        }


    }

    IEnumerator mine()
    {
    
            Debug.Log("Mouse is down");


        Debug.Log("Mouse is no longer down");
        yield return null;
    }
}
