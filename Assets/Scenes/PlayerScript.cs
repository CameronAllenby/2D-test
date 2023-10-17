using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Hscript helper;
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sr;
    
    // Start is called before the first frame update
    void Start()
    {
        
        helper = gameObject.AddComponent<Hscript>();
        print("start");
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }


    private void FixedUpdate()
    {
        
    }

    

    int playerHealth = 100;
    // Update is called once per frame
    void Update()
    {
        if (helper.OnCollisionEnter2D() == true);



        int speed = 1;
        anim.speed = 1;
        Vector2 velocity = rb.velocity;
        anim.SetBool("run", false);
        anim.SetBool("jump", false);
        
        if (Input.GetKey("v") == true)
        {
            anim.speed = 10;
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

        if (helper.DoRayCollisionCheck() == true)
        {
            if (Input.GetKey("space"))
            {
                velocity.y = 4f;
                print("do jump");
                
            }
        }
        if (helper.DoRayCollisionCheck() == false)
        {
            anim.SetBool("jump", true);
        }
       
        
            
        
        rb.velocity = velocity;

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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "coin")
            Destroy(other.gameObject);
    }

}
