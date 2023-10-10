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
        float speed = 1f;
        if (Input.GetKey("space"))
        {
            helper.FlipObject(true);    // this will execute the method in HelperScript.cs
        }

        Vector3 scale = transform.localScale;

        if (player.transform.position.x < 0.5 && transform.position.x > -0.5)
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
           
        }

        


    }*/
}
