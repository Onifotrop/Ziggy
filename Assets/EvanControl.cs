using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvanControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject evanBone;

    public GameObject evanAw;
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bone")
        {
            evanBone.GetComponent<SpriteRenderer>().enabled = false;
            evanAw.GetComponent<AreaEffector2D>().enabled = false;
            print("bone");
        }    
    }
}
