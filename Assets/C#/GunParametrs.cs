using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunParametrs : MonoBehaviour
{
    public int startCartridges;
    public int cartridges;

    public float offset;
    public int NumberOfBullets;
    public GameObject bullet;
    public Transform shootpoint;

    public GameObject effect;
    public Transform effectPoint;

    private float TimeBTWShots;
    public float StartTimeBTWShots;
    public Animator _animatorController;

    GunState Gstate;


    private void Start()
    {
        cartridges = startCartridges;
        _animatorController = GetComponent<Animator>();
    }
    void Update()
    {
        if (Gstate == GunState.Shoot)
        {
            _animatorController.Play("ShootingGun");
        }
        else
        {
            _animatorController.Play("IdleGun");
        }

        if (gameObject.CompareTag("Player1"))
        {
            if (TimeBTWShots <= 0)
            {
                if (Input.GetKey(KeyCode.V) && cartridges > 0)
                {
                    Gstate = GunState.Shoot;
                    Instantiate(effect, effectPoint.position, Quaternion.identity);
                    cartridges -= 1;
                    for (int i = 0; i < NumberOfBullets; i++)
                    {
                        Instantiate(bullet, shootpoint.position, transform.rotation);
                        TimeBTWShots = StartTimeBTWShots;
                    }
                }
                else if (Input.GetKey(KeyCode.V) && cartridges <= 0)
                {
                    Debug.Log("No more cartridges");
                }
            }
            else
            {
                TimeBTWShots -= Time.deltaTime;
                if (TimeBTWShots <= 0)
                {
                    Gstate = GunState.Idle;
                }
            }

        }
        else if (gameObject.CompareTag("Player2"))
        {

            if (TimeBTWShots <= 0)
            {
                if (Input.GetKey(KeyCode.K) && cartridges > 0)
                {
                    Gstate = GunState.Shoot;
                    Instantiate(effect, effectPoint.position, Quaternion.identity);
                    cartridges -= 2;
                    for (int i = 0; i < NumberOfBullets; i++)
                    {

                        Instantiate(bullet, shootpoint.position, transform.rotation);
                        TimeBTWShots = StartTimeBTWShots;
                    }
                }
                else if (Input.GetKey(KeyCode.K) && cartridges <= 0)
                {
                    Debug.Log("No more cartridges");
                }

            }
            else
            {
                TimeBTWShots -= Time.deltaTime;
                if (TimeBTWShots <= 0)
                {
                    Gstate = GunState.Idle;
                }
            }


        }


    }

    public enum GunState
    {
        Idle,
        Shoot
    }
}

