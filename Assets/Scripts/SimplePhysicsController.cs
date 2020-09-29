using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePhysicsController : MonoBehaviour
{
    public SpriteRenderer thisSprite;
    public Rigidbody2D thisRigidbody2D;
    public float force = 10f;
    public GroundCheck groundCheckScript;

    public float gravityInAir;
    public float jumpForce = 7f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            thisRigidbody2D.AddForce(Vector2.left * force * Time.deltaTime, ForceMode2D.Impulse);
            if (thisSprite.flipX == false)
            {
                thisSprite.flipX = true;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            thisRigidbody2D.AddForce(Vector2.right * force * Time.deltaTime, ForceMode2D.Impulse);
            if (thisSprite.flipX == true)
            {
                thisSprite.flipX = false;
            }
        }

        if (groundCheckScript.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                thisRigidbody2D.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);
                print("Jumping!");
            }

            thisRigidbody2D.gravityScale = 1;
        }

        if (groundCheckScript.isGrounded == false)
        {
            thisRigidbody2D.gravityScale = gravityInAir;
        }
    }
}
