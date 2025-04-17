using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class Mine : MonoBehaviour
{
    public GameObject hitboxPrefab;
    public Coroutine coroutine;
    public GameObject currentHitbox;
    public Transform parentObject;

    public UnityEvent mine;

    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;

    bool held = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (held == true)
        {
            t += Time.deltaTime;
        }
        else
        {
            t = 0;
        }

        if (t >= 1)
        {
            Debug.Log("Block Broken");
            t = 0;
            mine.Invoke();
            
            
        }

        if (Input.GetMouseButtonDown(0))
        {
           held = true;

            if (coroutine == null)
            {
                coroutine = StartCoroutine(MouseDown());
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            held = false;
            if (coroutine != null)
            {
                StopCoroutine(MouseDown());
                coroutine = null;
                
            }

            if(currentHitbox != null)
            {
                Destroy(currentHitbox);
                currentHitbox = null;
            }
        }
    }

    IEnumerator MouseDown()
    {
        while (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Button is Down");


            if (currentHitbox == null)
            {
                currentHitbox = Instantiate(hitboxPrefab, parentObject);
            }

            yield return null;
        }

        coroutine = null;

    }
}
