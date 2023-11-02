using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTouch : MonoBehaviour
{
    private void Update()
    {
        GetTouch();
    }

    private void GetTouch()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Touch detected");
        }

        if (Input.touchCount == 1)
        {
            Debug.Log("Touch detected");
        }
    }
}
