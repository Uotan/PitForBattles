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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            collision.gameObject.GetComponent<Player1>().TakeDamage(damage);


        }
        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    collision.gameObject.GetComponent<LocalTestPlayer>().TakeDamage(damage);
        //}
        if (collision.gameObject.CompareTag("Player2"))
        {
            collision.gameObject.GetComponent<Player2>().TakeDamage(damage);
        }
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        HIT.Play("BulletHit");
        BC2D.enabled = false;
        Invoke("Des", 0.2f);
    }
    private void Des(){
        Destroy(gameObject);
    }
    
}

        

   

