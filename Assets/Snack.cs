using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject word1;
    public GameObject word2;
    public GameObject word3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        word1.GetComponent<SpriteRenderer>().enabled = false;
        word2.GetComponent<SpriteRenderer>().enabled = true;
        word3.GetComponent<SpriteRenderer>().enabled = true;
        this.GetComponent<SpriteRenderer>().enabled = false;
    }
}
