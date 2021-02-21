using UnityEngine;
using System.Collections;

class Bullet : MonoBehaviour
{
        public float lifetime;
        public int damage;
        public int speed;
//      ==================================================
//      ==================================================
        void Update ()
        {
            transform.Translate (speed*Time.deltaTime, 0, 0 );
                if (lifetime <= 0)
                {
                    Destroy(gameObject);
                }
            lifetime -= Time.deltaTime;
        }
//      ==================================================
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
//      ==================================================
}
