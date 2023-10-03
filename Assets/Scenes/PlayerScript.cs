using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        print("start");
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }


    private void FixedUpdate()
    {
        print("yv=" + rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {

        
        
        
        int speed = 1;
        Vector2 velocity = rb.velocity;
        anim.SetBool("run", false);
        anim.SetBool("jump", false);
       
        if (Input.GetKey("v") == true)
        {
            speed = 2;
        }

        if (Input.GetKeyDown("s"))
        {
            anim.SetTrigger("attack2");


        }
        if (Input.GetKeyDown("e"))
        {
            anim.SetTrigger("attack1");
            

        }
        if (Input.GetKey("space") && velocity.y == 0f) 
        {
            velocity.y = 5f;
            if (velocity.y != 0)
                {
                anim.SetBool("jump", true);
            }
            
        }
        rb.velocity = velocity;
        /*if (Input.GetKey("s") == true)
        {
            print("player pressed down");
            transform.position = new Vector2(transform.position.x, transform.position.y + (-speed * Time.deltaTime));
        }*/
        if (Input.GetKey("a") == true)
        {
            print("player pressed left");
            sr.flipX = false;
            anim.SetBool("run", true);
            transform.position = new Vector2(transform.position.x + (-speed * Time.deltaTime), transform.position.y);
        }
        if (Input.GetKey("d") == true)
        {
            print("player pressed right");
            anim.SetBool("run", true);
            sr.flipX = true;
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        }
    }
}
