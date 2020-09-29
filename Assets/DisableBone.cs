using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableBone : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bone;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bone")
        {
            print("entered");
            Bone.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
