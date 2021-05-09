using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForGuns1 : MonoBehaviour
{
    public GameObject Revolver;
    GunParametrs RevolverPar;
    public GameObject ShootGun;
    GunParametrs ShootGunPar;
    public GameObject AutoGun;
    GunParametrs AutoGunPar;
    public Text text1;

    private void Start() {
        RevolverPar = Revolver.GetComponent<GunParametrs>();
        ShootGunPar = ShootGun.GetComponent<GunParametrs>();
        AutoGunPar = AutoGun.GetComponent<GunParametrs>();
    }
    void Update()
    {
        if (Revolver.activeInHierarchy)
        {
            text1.text=RevolverPar.cartridgesInBarage.ToString()+"/"+RevolverPar.cartridges.ToString();
        }
        if (ShootGun.activeInHierarchy)
        {
            text1.text=ShootGunPar.cartridges.ToString();
        }
        if (AutoGun.activeInHierarchy)
        {
            text1.text=AutoGunPar.cartridgesInBarage.ToString()+"/"+AutoGunPar.cartridges.ToString();
        }
    }
}
