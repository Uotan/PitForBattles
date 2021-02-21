using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public int weaponSwitch =0;
    // Start is called before the first frame update
    void Start()
    {
       SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int currentWeapon=weaponSwitch;
        if(Input.GetKeyDown(KeyCode.B))
       {
           if(weaponSwitch>=transform.childCount-1)
           {
               weaponSwitch=0;
           }
           else 
           {
               weaponSwitch++;
           }
           if (currentWeapon!=weaponSwitch)
           {
               SelectWeapon();
           }
       } 
    }
    void SelectWeapon()
    {
        int i =0;
        foreach(Transform weapon in transform)
        {
            if(i==weaponSwitch)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
