using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZiggyController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tips;
    public float dialogCnt = 0;
    public GameObject ziggyOne;
    public GameObject ziggyTwo;
    public GameObject playerOne;
    public bool startDia;
    public GameObject Q1;
    public GameObject Q12;
    public GameObject Q2;
    public GameObject Q22;
    void Update()
    {
        if (startDia)
        {
            dialogCnt += 1 * Time.deltaTime;
            
        }
        if (dialogCnt >= 1 && dialogCnt < 2)
        {
            ziggyOne.GetComponent<SpriteRenderer>().enabled = true;
            tips.GetComponent<SpriteRenderer>().enabled = false;
        }
         
        if (dialogCnt >= 2 && dialogCnt < 3) 
        { 
            playerOne.GetComponent<SpriteRenderer>().enabled = true; 
            ziggyOne.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (dialogCnt >= 3 && dialogCnt < 4)
        {
            ziggyTwo.GetComponent<SpriteRenderer>().enabled = true;
            playerOne.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (dialogCnt >= 4)
        {
            ziggyTwo.GetComponent<SpriteRenderer>().enabled = false;
            
        }

        if (dialogCnt > 5)
        {
            startDia = false;
            dialogCnt = 5;
            Q1.GetComponent<SpriteRenderer>().enabled = true;
            Q2.GetComponent<SpriteRenderer>().enabled = true;

        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            tips.GetComponent<SpriteRenderer>().enabled = true;
            if (Input.GetKey(KeyCode.E))
            {
                startDia = true;
            }

            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        tips.GetComponent<SpriteRenderer>().enabled = false;
    }
}
