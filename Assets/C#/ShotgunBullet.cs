using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunBullet : MonoBehaviour
{
    public float speedXmin;
    public float speedXmax;
    public float lifetime;
    public int damage;
    public float YRangePlus;
    public float YRangeMinus;
    [HideInInspector]
    public float Y;
    [HideInInspector]
    public float X;

    public Rigidbody2D rb;


    private void Start()
    {       
            float randX = Random.Range(speedXmin,speedXmax);
             X = randX;
            float randY = Random.Range(-YRangeMinus, YRangePlus);
             Y = randY; 

           
            rb.velocity =transform.right*-X;
            rb.AddForce ((transform.up*Y*Time.deltaTime));
            

    }

    private void Update()
    { 
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
        lifetime -= Time.deltaTime;
        

        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Bullet"))
        {
                    
        }
        else
        {
            if (other.CompareTag("Enemy"))
            {
                other.GetComponent<Player1>().TakeDamage(damage);
            }
            if (other.CompareTag("Enemy1"))
            {
                other.GetComponent<Player2>().TakeDamage(damage);
            }
            Destroy(gameObject);
        }    
    }
    
}

        

   

