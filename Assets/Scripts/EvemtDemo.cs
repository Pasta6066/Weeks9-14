using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EvemtDemo : MonoBehaviour
{
    public RectTransform banana;

    public UnityEvent OnTimerHasFinished;
    public float timerLength = 3;
    public float t;

    private void Update()
    {
        t += Time.deltaTime;
        if(t > timerLength)
        {
            t = 0;
            OnTimerHasFinished.Invoke();
        }
    }

    public void MouseJustEnteredImage()
    {
        Debug.Log("Mouse just entered me!");
        banana.localScale = Vector3.one * 1.2f;
    }

    public void MouseJustExitImage()
    {
        Debug.Log("Mouse just exited me!");
        banana.localScale = Vector3.one;
    }
}
