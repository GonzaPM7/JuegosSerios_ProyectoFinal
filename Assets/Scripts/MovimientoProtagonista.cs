using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoProtagonista : MonoBehaviour
{

    public float speed;
    float moved = 0f;
    public float MAX_FUERZA;
    Rigidbody2D rb;
    public float climbSpeed;
    bool control = true;
    bool canClimb = false;
    Animator animator;
    private int _currentAnimation = ANIMATION_STANDING;
    public int MAX_SALTOS;
    int nsaltos;

    const int ANIMATION_STANDING = 0;
    const int ANIMATION_WALKING = 1;
    const int ANIMATION_JUMPING = 2;
    const int ANIMATION_FALLING = 3;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        nsaltos = MAX_SALTOS;

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

    public void setAnimation(int animation)
    {
        if (_currentAnimation != animation)
        {
            animator.SetInteger("animation", animation);
            _currentAnimation = animation;
        }
    }

    public void Movimiento()
    {
        float vy = rb.velocity.y;

        moved = Input.GetAxis("Horizontal");
        if (moved < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;            
        }
        else if (moved > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;            
        }

        if (moved != 0)
        {
            setAnimation(ANIMATION_WALKING);
        } else
        {
            setAnimation(ANIMATION_STANDING);
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (nsaltos > 0)
            {
                vy = MAX_FUERZA;
                nsaltos -= 1;
            }
        }

        rb.velocity = new Vector2(moved * speed, vy);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suelo" || collision.gameObject.tag == "Suelo1" || collision.gameObject.tag == "Caja")
        {
            nsaltos = 2;
        }
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
