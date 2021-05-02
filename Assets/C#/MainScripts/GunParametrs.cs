using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunParametrs : MonoBehaviour
{
    static string shoottPREFS;
    KeyCode shootBUTT;


    //проверка на перезарядку, чтобы игрок не мог менять оружие во время перезарядки
    public ReloadChecker isReloadedscript;



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


    bool jstCheckbool = false;

    GunState Gstate;


    private void Start()
    {
        if (gameObject.CompareTag("Player1"))
        {
            shoottPREFS = PlayerPrefs.GetString("Set_p1_shoot");
            shootBUTT = (KeyCode)System.Enum.Parse(typeof(KeyCode), shoottPREFS);
        }
        if (gameObject.CompareTag("Player2"))
        {
            shoottPREFS = PlayerPrefs.GetString("Set_p2_shoot");
            shootBUTT = (KeyCode)System.Enum.Parse(typeof(KeyCode), shoottPREFS);
        }

        cartridges = startCartridges;
        cartridgesInBarage = startCartridgesInBarage;

        _animatorController = GetComponent<Animator>();
    }
    void Update()
    {
        if (cartridgesInBarage <= 0 && cartridges > 0 && jstCheckbool == false)
        {
            reloadTime = startReloadTime;
            Debug.Log("Reload");
            jstCheckbool = true;
            Invoke("Reload", 0.2f);
            //Reload();
        }
        if (Gstate == GunState.Shoot)
        {
            _animatorController.Play("ShootingGun");
        }
        else if (Gstate == GunState.Reload)
        {
            //проверка на перезарядку, чтобы игрок не мог менять оружие во время перезарядки
            isReloadedscript.isReload = true;
            _animatorController.Play("ReloadGun");
        }
        else
        {
            //проверка на перезарядку, чтобы игрок не мог менять оружие во время перезарядки
            isReloadedscript.isReload = false;
            _animatorController.Play("IdleGun");
        }
        if (reloadTime <= 0)
        {
                if (TimeBTWShots <= 0)
                {
                    if (Input.GetKey(shootBUTT) && cartridgesInBarage > 0)
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
            reloadTime -= Time.deltaTime;
        }
    }

    void Reload()
    {
        if (cartridges >= 0)
        {
            Gstate = GunState.Reload;
            if (cartridges - startCartridgesInBarage >= 0)
            {
                cartridges = cartridges - startCartridgesInBarage;
                cartridgesInBarage = startCartridgesInBarage;
            }
            else if (cartridges - startCartridgesInBarage < startCartridgesInBarage)
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
        jstCheckbool = false;
    }
    public enum GunState
    {
        Idle,
        Shoot,
        Reload
    }
}