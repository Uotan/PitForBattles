using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunBullet : MonoBehaviour
{
    public float speedXmin;
    public float speedXmax;
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask WhatIsSolid;
    public float YRangePlus;
    public float YRangeMinus;
    [HideInInspector]
    public float Y;
    public float X;

    private (float X, float Y) Start()
    {       float randX = Random.Range(speedXmin,speedXmax);
             X = randX;
            float randY = Random.Range(-YRangeMinus, YRangePlus);
             Y = randY; 
             return (X,Y);


    }

    private void Update()
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, transform.up, distance, WhatIsSolid);
        if (raycastHit2D.collider != null)
        {
            if (raycastHit2D.collider.CompareTag("Enemy"))
            {
                raycastHit2D.collider.GetComponent<Enemy>().TakeDamage(damage);

            }
            Destroy(gameObject);

        }
        
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
        lifetime -= Time.deltaTime;
        
        transform.Translate(-X * Time.deltaTime,Y*Time.deltaTime, 0);
    }
    
}
