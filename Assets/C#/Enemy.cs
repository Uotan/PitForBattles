using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
       public float speed;
       // Start is called before the first frame update
       void Update()
       {
           if (health<=0)
           {
               Destroy(gameObject);
           }
           transform.Translate(Vector2.left * (speed * Time.deltaTime));
       }
   
       // Update is called once per frame
       public void TakeDamage(int damage)
       {
           health -= damage;
       }
}
