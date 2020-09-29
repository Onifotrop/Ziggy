using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneControll : MonoBehaviour
{
    public bool picked;
    
    public GameObject player;

    public GameObject coop1;

    public GameObject coop2;

    public GameObject evan;
    // Update is called once per frame
    void Update()
    {
        if (picked)
        {
            this.transform.position = player.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            picked = true;
            coop1.GetComponent<SpriteRenderer>().enabled = false;
            coop2.GetComponent<SpriteRenderer>().enabled = true;
            evan.GetComponent<AreaEffector2D>().enabled = false;
            this.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
