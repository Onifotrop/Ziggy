using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCam : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }
}
