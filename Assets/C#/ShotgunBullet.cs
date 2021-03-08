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

    [HideInInspector]
    public Rigidbody2D rb;
    [HideInInspector]
    public Animator HIT;
    [HideInInspector]
    public BoxCollider2D BC2D;


    private void Start()
    {       
            rb = GetComponent<Rigidbody2D>();
            HIT=GetComponent<Animator>();
            BC2D=GetComponent<BoxCollider2D>();
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
        if (other.CompareTag("Bullet")||other.CompareTag("Weapon")||other.CompareTag("Health"))
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
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            BC2D.enabled=false;
            HIT.Play("BulletHit");
            Invoke("Des",0.2f);
        }    
    }
    private void Des(){
        Destroy(gameObject);
    }
    
}

        

   

