using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoProtagonista : MonoBehaviour
{

    public float speed;
    float moved = 0f;

    Rigidbody2D rb;

    public float climbSpeed;
    

    bool control = true;

    bool canClimb = false;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        control = true;
    }
    void Update()
    {  
         
        if (control)
        {
            Movimiento();
        }

        if (canClimb)
            Ladder();
    }

    public void Movimiento()
    {
        moved = Input.GetAxis("Horizontal");
        if (moved < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;            
        }
        else if (moved > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;            
        }
        
        rb.velocity = new Vector2(moved * speed, rb.velocity.y);
    }

    void Ladder()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0, 1) * climbSpeed;
            rb.gravityScale = 0;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -1) * climbSpeed;
            rb.gravityScale = 0;
        }
        rb.gravityScale = 1;
    }    

    public void CanClimb(bool can)
    {
        canClimb = can;
    }

}
