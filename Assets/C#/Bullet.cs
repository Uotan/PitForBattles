using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask WhatIsSolid;

    private void Update()
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, transform.up, distance, WhatIsSolid);
        if (raycastHit2D.collider!=null)
        {
            if (raycastHit2D.collider.CompareTag("Enemy"))
            {
                raycastHit2D.collider.GetComponent<Enemy>().TakeDamage(damage);

            }
            Destroy(gameObject);

        }
        if (lifetime<=0)
        {
            Destroy(gameObject);
        }
        lifetime -= Time.deltaTime;
        transform.Translate(Vector2.right * (speed * Time.deltaTime));
    }
}
