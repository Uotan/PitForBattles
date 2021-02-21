using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int _speed;
    public Vector2 moveVector;
    public bool flip = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        walk();
    }

     void walk()
     {
         moveVector.x = Input.GetAxis("Horizontal");
         
         rb.velocity = new Vector2(moveVector.x * _speed, rb.velocity.y);
         if (moveVector.x<0&&!flip)
         {
             Flip();
         }
         if (moveVector.x > 0 && flip)
         {
             Flip();
         }
     }

     void Flip()
     {
         flip = !flip;
         this.gameObject.transform.Rotate(0, 180, 0);
         
     }
     
     
}
