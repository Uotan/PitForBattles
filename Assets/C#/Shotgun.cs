using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{

    public float offset;
    public int NumberOfBullets;
    public GameObject bullet;
    public Transform shootpoint;

    private float TimeBTWShots;
    private float TimeBTWAnimation=0.3f;
    public float StartTimeBTWShots;
    public Animator _animatorController;

    GunState Gstate;
    

    private void Start() 
    {
        _animatorController = GetComponent<Animator>();
    }
    void Update()
    {
        if (Gstate==GunState.Shoot)
        {
            _animatorController.Play("ShootingShotgun");
        }
        else
        {
            _animatorController.Play("IdleShotgun");
        }
        
        if (gameObject.CompareTag("Player1"))
        {
            if (TimeBTWShots <= 0)
            {
                if (Input.GetKey(KeyCode.V))
                {
                    
                    for (int i = 0; i < NumberOfBullets; i++)
                    {

                        Instantiate(bullet, shootpoint.position,transform.rotation);
                        TimeBTWShots = StartTimeBTWShots;
                    }
                     Gstate=GunState.Shoot;
                    
                }
            }
            else
            {
                TimeBTWShots -= Time.deltaTime;
                TimeBTWAnimation-=Time.deltaTime;
                if (TimeBTWAnimation<=0)
                {
                    Gstate=GunState.Idle;
                    TimeBTWAnimation=0.3f;
                }
            } 
        }
        else if (gameObject.CompareTag("Player2"))
        {
            if (TimeBTWShots <= 0)
            {
                if (Input.GetKey(KeyCode.K))
                {
                    Gstate=GunState.Shoot;
                   
                    for (int i = 0; i < NumberOfBullets; i++)
                    {

                        Instantiate(bullet, shootpoint.position,transform.rotation);
                        TimeBTWShots = StartTimeBTWShots;
                    }
                    
                }
            }
            else
            {
                TimeBTWShots -= Time.deltaTime;
                if (TimeBTWShots<=0)
                {
                    Gstate=GunState.Idle;
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

