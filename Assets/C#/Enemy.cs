using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

       // Start is called before the first frame update
       void Update()
       {
           if (health<=0)
           {
               Destroy(gameObject);
           }
           
       }
   
       // Update is called once per frame
       public void TakeDamage(int damage)
       {
           health -= damage;
       }
}
