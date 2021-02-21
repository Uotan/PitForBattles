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


    private (float X, float Y) Start()
    {       
            float randX = Random.Range(speedXmin,speedXmax);
             X = randX;
            float randY = Random.Range(-YRangeMinus, YRangePlus);
             Y = randY; 
             return (X,Y);


    }

    private void Update()
    { 
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
        lifetime -= Time.deltaTime;
        

        transform.Translate(-X * Time.deltaTime,Y*Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {

        }
        else
        {
            if (other.CompareTag("Enemy"))
            {
                other.GetComponent<Enemy>().TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }


}
