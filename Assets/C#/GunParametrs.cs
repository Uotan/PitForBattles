using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunParametrs : MonoBehaviour
{
    static string p1_shoottPREFS;
    KeyCode p1_shootBUTT;

    





    public int startCartridges;
    public int cartridges;

    public int startCartridgesInBarage;
    public int cartridgesInBarage;

    
    public float offset;
    public int NumberOfBullets;
    public GameObject bullet;
    public Transform shootpoint;

    public GameObject effect;
    public Transform effectPoint;

    [HideInInspector]
    private float TimeBTWShots;
    public float StartTimeBTWShots;
    [HideInInspector]
    public float reloadTime;
    public float startReloadTime;
    public Animator _animatorController;

    GunState Gstate;


    private void Start()
    {
        //**********************************
        p1_shoottPREFS = PlayerPrefs.GetString("Set_p1_shoot");
        p1_shootBUTT = (KeyCode)System.Enum.Parse(typeof(KeyCode), p1_shoottPREFS);

        
        //**********************************

        cartridges = startCartridges;
        cartridgesInBarage = startCartridgesInBarage;
        
        _animatorController = GetComponent<Animator>();
    }
    void Update()
    {
        if (cartridgesInBarage <= 0&&cartridges>0)
        {
            reloadTime = startReloadTime;
            Gstate = GunState.Reload;
            Debug.Log("Reload");
            Reload();
        }
        if (Gstate == GunState.Shoot)
        {
            _animatorController.Play("ShootingGun");
        }
        else if (Gstate == GunState.Reload)
        {
            _animatorController.Play("ReloadGun");
        }
        else
        {
            _animatorController.Play("IdleGun");
        }

        if (gameObject.CompareTag("Player1"))
        {   
            if(reloadTime<=0)
            {
                if (TimeBTWShots <= 0)
                {
                    if (Input.GetKey(p1_shootBUTT) && cartridgesInBarage > 0)
                    {
                        Gstate = GunState.Shoot;
                        Instantiate(effect, effectPoint.position, Quaternion.identity);
                        cartridgesInBarage -= 1;
                        for (int i = 0; i < NumberOfBullets; i++)
                        {
                            Instantiate(bullet, shootpoint.position, transform.rotation);
                            TimeBTWShots = StartTimeBTWShots;
                        }
                    }
                    else if (Input.GetKey(p1_shootBUTT) && cartridgesInBarage <= 0&&cartridges>0)
                    {
                        reloadTime = startReloadTime;
                        Gstate = GunState.Reload;
                        Debug.Log("Reload");

                        Reload();

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
            else
            {
                reloadTime-=Time.deltaTime;
            }


        }
        else if (gameObject.CompareTag("Player2"))
        {

           if(reloadTime<=0)
            {
                if (TimeBTWShots <= 0)
                {
                    if (Input.GetKey(KeyCode.K) && cartridgesInBarage > 0)
                    {
                        Gstate = GunState.Shoot;
                        Instantiate(effect, effectPoint.position, Quaternion.identity);
                        cartridgesInBarage -= 1;
                        for (int i = 0; i < NumberOfBullets; i++)
                        {
                            Instantiate(bullet, shootpoint.position, transform.rotation);
                            TimeBTWShots = StartTimeBTWShots;
                        }
                    }
                    else if (Input.GetKey(KeyCode.K) && cartridgesInBarage <= 0&&cartridges>0)
                    {
                        reloadTime = startReloadTime;
                        Gstate = GunState.Reload;
                        Debug.Log("Reload");

                        Reload();

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
            else
            {
                reloadTime-=Time.deltaTime;
            }

        }


    }

    void Reload()
    {   if(cartridges>=0)
        {   
            if (cartridges-startCartridgesInBarage>=0)
            {
                cartridges = cartridges-startCartridgesInBarage;
                cartridgesInBarage = startCartridgesInBarage;
            }
            else if(cartridges-startCartridgesInBarage<startCartridgesInBarage)
            {
               
                int halfEmptyBarage = cartridges;
                cartridges -= halfEmptyBarage;
                cartridgesInBarage = halfEmptyBarage;
            }
            else
            {
                Debug.Log("No more cartridges");
            }
            
        }
        else
        {
            Debug.Log("No more cartridges");
        }
    }
    public enum GunState
    {
        Idle,
        Shoot,
        Reload
    }
}

