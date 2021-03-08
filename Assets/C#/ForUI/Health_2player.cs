using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_2player : MonoBehaviour
{
    public Player2 Pscript;
    public Text text1;
    void Update()
    {
        if (Pscript.health>=0)
        {
            text1.text=Pscript.health.ToString();
        }
        else
        {
            text1.text="0";
        }
    }
}
