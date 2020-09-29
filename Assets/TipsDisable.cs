using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsDisable : MonoBehaviour
{
    public GameObject Tips;
    // Start is called before the first frame update
    public void OnTriggerStay2D(Collider2D other)
    {
        Tips.GetComponent<SpriteRenderer>().enabled = false;
    }
}
