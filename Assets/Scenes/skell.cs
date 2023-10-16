using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class skell : MonoBehaviour
{
    Hscript helper;
    public GameObject player;
    SpriteRenderer sr;
    void Start()
    {
        helper = gameObject.AddComponent<Hscript>();
        sr = GetComponent<SpriteRenderer>();
        
    }

    
    // Update is called once per frame
    void Update()
    {
        int speed = 0;
        if (helper.Pacing() != 1)
        {
            speed = 1;
            if (helper.Pacing() == 2)
            {
                speed = 1;
            }
            if (helper.Pacing() == 3)
            {
                speed = -1;
            }
        }
        transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        //float speed = 1f;


        //Vector3 scale = transform.localScale;

        /*if (player.transform.position.x < 0.5 && transform.position.x > -0.5)
        {
            speed = 0;
            print("yes");
        }

        if (player.transform.position.x > transform.position.x) 
        {
            sr.flipX = true;
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        }

        else 
        { 
            sr.flipX = false;
            transform.position = new Vector2(transform.position.x + (-speed * Time.deltaTime), transform.position.y);
        }
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision != null && collision.gameObject.name == "CoolGuy")
        {
            speed = 0f;
           
        }*/




    }
}
