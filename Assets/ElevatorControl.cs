using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorControl : MonoBehaviour
{
    public GameObject elevator;

    public float eleForce;

    public bool buttonPressed;

    public GameObject airWall;

    public GameObject tips;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPressed)
        {
            if (elevator.transform.position.y < 22.8)
            {
                elevator.transform.Translate(0, eleForce * Time.deltaTime, 0);
            }
                
            
            
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (!buttonPressed)
            {
                tips.GetComponent<SpriteRenderer>().enabled = true; 
            }
            print("Player is in");
            if (Input.GetKeyDown(KeyCode.E))
            {
                buttonPressed = true;
                airWall.GetComponent<BoxCollider2D>().enabled = true;
                tips.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}
