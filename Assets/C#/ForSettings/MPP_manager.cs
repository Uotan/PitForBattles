using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MPP_manager : MonoBehaviour
{
    public string net_left;
    public Text net_leftTEXT;


    public string net_right;
    public Text net_rightTEXT;


    public string net_jump;
    public Text net_jumpTEXT;


    public string net_shoot;
    public Text net_shootTEXT;


    public string net_switch;
    public Text net_switchTEXT;
    void Start()
    {
        //движение влево
        if (PlayerPrefs.HasKey("Set_net_left"))
        {
            net_left = PlayerPrefs.GetString("Set_net_left");
            net_leftTEXT.text = net_left;
        }
        else
        {
            PlayerPrefs.SetString("Set_net_left", "A");
            net_left = PlayerPrefs.GetString("Set_net_left");
            net_leftTEXT.text = net_left;
        }


        //движение вправо
        if (PlayerPrefs.HasKey("Set_net_right"))
        {
            net_right = PlayerPrefs.GetString("Set_net_right");
            net_rightTEXT.text = net_right;
        }
        else
        {
            PlayerPrefs.SetString("Set_net_right", "D");
            net_right = PlayerPrefs.GetString("Set_net_right");
            net_rightTEXT.text = net_right;
        }


        //прыжок
        if (PlayerPrefs.HasKey("Set_net_jump"))
        {
            net_jump = PlayerPrefs.GetString("Set_net_jump");
            net_jumpTEXT.text = net_jump;
        }
        else
        {
            PlayerPrefs.SetString("Set_net_jump", "W");
            net_jump = PlayerPrefs.GetString("Set_net_jump");
            net_jumpTEXT.text = net_jump;
        }


        //выстрел
        if (PlayerPrefs.HasKey("Set_net_shoot"))
        {
            net_shoot = PlayerPrefs.GetString("Set_net_shoot");
            net_shootTEXT.text = net_shoot;
        }
        else
        {
            PlayerPrefs.SetString("Set_net_shoot", "V");
            net_shoot = PlayerPrefs.GetString("Set_net_shoot");
            net_shootTEXT.text = net_shoot;
        }


        //смена оружия
        if (PlayerPrefs.HasKey("Set_net_swith"))
        {
            net_switch = PlayerPrefs.GetString("Set_net_swith");
            net_switchTEXT.text = net_switch;
        }
        else
        {
            PlayerPrefs.SetString("Set_net_swith", "B");
            net_switch = PlayerPrefs.GetString("Set_net_swith");
            net_switchTEXT.text = net_switch;
        }
    }
}
