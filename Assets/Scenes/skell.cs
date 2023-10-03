using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class skell : MonoBehaviour
{
    public GameObject player;
    SpriteRenderer sr;
    void Start()
    {
        
        sr = GetComponent<SpriteRenderer>();
    }

    float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        speed = 1f;




        Vector3 scale = transform.localScale;

        
        if (player.transform.position.x > transform.position.x)
        {
            
            sr.flipX = true;
            transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        }

       

        else if (player.transform.position.x < transform.position.x)
        {
            
            sr.flipX = false;
            transform.position = new Vector2(transform.position.x + (-speed * Time.deltaTime), transform.position.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision != null && collision.gameObject.name == "CoolGuy")
        {
            speed = 0f;
           
        }

        


    }
}
