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

        if (TimeBTWShots<=0)
        {
            if (Input.GetKey(KeyCode.V))
            {
                Instantiate(bullet, shootpoint.position, transform.rotation);
                TimeBTWShots = StartTimeBTWShots;
            }
        }
        else
        {
            TimeBTWShots -= Time.deltaTime;
        }
    }
}
