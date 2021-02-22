using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGun : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootpoint;

    private float TimeBTWShots;
    public float  StartTimeBTWShots;

    void Update()
    {

        if (gameObject.CompareTag("Player1"))
        {
            if (TimeBTWShots <= 0)
            {
                if (Input.GetKey(KeyCode.V))
                {
                        Instantiate(bullet, shootpoint.position,transform.rotation);
                        TimeBTWShots = StartTimeBTWShots;
                }
            }
            else
            {
                TimeBTWShots -= Time.deltaTime;
            } 
        }
        else if (gameObject.CompareTag("Player2"))
        {
            if (TimeBTWShots <= 0)
            {
                if (Input.GetKey(KeyCode.N))
                {
                        Instantiate(bullet, shootpoint.position,transform.rotation);
                        TimeBTWShots = StartTimeBTWShots; 
                }
            }
            else
            {
                TimeBTWShots -= Time.deltaTime;
            } 
        }
    }
}
