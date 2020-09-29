using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded;
    public void OnTriggerStay2D(Collider2D other)
    {
        print(other.name);
        print("Grounded");
        if (other.tag == "Ground")
        {
            isGrounded = true;
        }
        
    }
    public void OnTriggerExit2D()
    {
        isGrounded = false;
    }
}
