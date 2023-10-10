using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hscript : MonoBehaviour
{
    LayerMask groundLayerMask;
    void Start()
    {
        // set the mask to be "Ground"
        groundLayerMask = LayerMask.GetMask("Ground");
    }



    public bool DoRayCollisionCheck()
    {
       
        float rayLength = 0.5f; // length of raycast


        //cast a ray downward 
        RaycastHit2D hit;

        hit = Physics2D.Raycast(transform.position, -Vector2.up, rayLength, groundLayerMask);
        bool ground = false;
        Color hitColor = Color.white;
        Debug.DrawRay(transform.position, -Vector2.up * rayLength, hitColor);

        if (hit.collider != null)
        {
            print("Player has collided with Ground layer");
            ground = true;

        }
        else
        {
            ground = false;
        }
        return ground;
        // draw a debug ray to show ray position
        // You need to enable gizmos in the editor to see these
        

    }
    
    public void FlipObject(bool flip)
    {
        // get the SpriteRenderer component
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();

        if (flip == true)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }

        // Start is called before the first frame update

    }


}
