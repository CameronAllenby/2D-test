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

    int speed = 1;
    // Update is called once per frame
    private void Update()
    {

        if (helper.Pacing() != 1)
        {
            speed = speed * -1;
            if (helper.Pacing() != 2)
            {
                sr.flipX = true;
            }
            else
            {
                sr.flipX = false;
            }
        }
        transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);




    }
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "CoolGuy")
        {
            print("ggg");

        }
    }

}

