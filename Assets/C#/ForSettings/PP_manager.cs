using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PP_manager : MonoBehaviour
{
    public string p1_left;
    public Text p1_leftTEXT;


    public string p1_right;
    public Text p1_rightTEXT;


    public string p1_jump;
    public Text p1_jumpTEXT;


    public string p1_shoot;
    public Text p1_shootTEXT;


    public string p1_switch;
    public Text p1_switchTEXT;


    public string p2_left;
    public Text p2_leftTEXT;


    public string p2_right;
    public Text p2_rightTEXT;


    public string p2_jump;
    public Text p2_jumpTEXT;


    public string p2_shoot;
    public Text p2_shootTEXT;


    public string p2_switch;
    public Text p2_switchTEXT;
    void Start()
    {
        //движение влево
        if (PlayerPrefs.HasKey("Set_p1_left"))
        {
            p1_left = PlayerPrefs.GetString("Set_p1_left");
            p1_leftTEXT.text = p1_left;
        }
        else
        {
            PlayerPrefs.SetString("Set_p1_left", "A");
            p1_left = PlayerPrefs.GetString("Set_p1_left");
            p1_leftTEXT.text = p1_left;
        }


        //движение вправо
        if (PlayerPrefs.HasKey("Set_p1_right"))
        {
            p1_right = PlayerPrefs.GetString("Set_p1_right");
            p1_rightTEXT.text = p1_right;
        }
        else
        {
            PlayerPrefs.SetString("Set_p1_right", "D");
            p1_right = PlayerPrefs.GetString("Set_p1_right");
            p1_rightTEXT.text = p1_right;
        }


        //прыжок
        if (PlayerPrefs.HasKey("Set_p1_jump"))
        {
            p1_jump = PlayerPrefs.GetString("Set_p1_jump");
            p1_jumpTEXT.text = p1_jump;
        }
        else
        {
            PlayerPrefs.SetString("Set_p1_jump", "W");
            p1_jump = PlayerPrefs.GetString("Set_p1_jump");
            p1_jumpTEXT.text = p1_jump;
        }


        //выстрел
        if (PlayerPrefs.HasKey("Set_p1_shoot"))
        {
            p1_shoot = PlayerPrefs.GetString("Set_p1_shoot");
            p1_shootTEXT.text = p1_shoot;
        }
        else
        {
            PlayerPrefs.SetString("Set_p1_shoot", "V");
            p1_shoot = PlayerPrefs.GetString("Set_p1_shoot");
            p1_shootTEXT.text = p1_shoot;
        }


        //смена оружия
        if (PlayerPrefs.HasKey("Set_p1_swith"))
        {
            p1_switch = PlayerPrefs.GetString("Set_p1_swith");
            p1_switchTEXT.text = p1_switch;
        }
        else
        {
            PlayerPrefs.SetString("Set_p1_swith", "B");
            p1_switch = PlayerPrefs.GetString("Set_p1_swith");
            p1_switchTEXT.text = p1_switch;
        }



        //*********************************************
        //движение влево
        if (PlayerPrefs.HasKey("Set_p2_left"))
        {
            p2_left = PlayerPrefs.GetString("Set_p2_left");
            p2_leftTEXT.text = p2_left;
        }
        else
        {
            PlayerPrefs.SetString("Set_p2_left", "LeftArrow");
            p2_left = PlayerPrefs.GetString("Set_p2_left");
            p2_leftTEXT.text = p2_left;
        }


        //движение вправо
        if (PlayerPrefs.HasKey("Set_p2_right"))
        {
            p2_right = PlayerPrefs.GetString("Set_p2_right");
            p2_rightTEXT.text = p2_right;
        }
        else
        {
            PlayerPrefs.SetString("Set_p2_right", "RightArrow");
            p2_right = PlayerPrefs.GetString("Set_p2_right");
            p2_rightTEXT.text = p2_right;
        }


        //прыжок
        if (PlayerPrefs.HasKey("Set_p2_jump"))
        {
            p2_jump = PlayerPrefs.GetString("Set_p2_jump");
            p2_jumpTEXT.text = p2_jump;
        }
        else
        {
            PlayerPrefs.SetString("Set_p2_jump", "UpArrow");
            p2_jump = PlayerPrefs.GetString("Set_p2_jump");
            p2_jumpTEXT.text = p2_jump;
        }


        //выстрел
        if (PlayerPrefs.HasKey("Set_p2_shoot"))
        {
            p2_shoot = PlayerPrefs.GetString("Set_p2_shoot");
            p2_shootTEXT.text = p2_shoot;
        }
        else
        {
            PlayerPrefs.SetString("Set_p2_shoot", "Mouse0");
            p2_shoot = PlayerPrefs.GetString("Set_p2_shoot");
            p2_shootTEXT.text = p2_shoot;
        }


        //смена оружия
        if (PlayerPrefs.HasKey("Set_p2_swith"))
        {
            p2_switch = PlayerPrefs.GetString("Set_p2_swith");
            p2_switchTEXT.text = p2_switch;
        }
        else
        {
            PlayerPrefs.SetString("Set_p2_swith", "Mouse1");
            p2_switch = PlayerPrefs.GetString("Set_p2_swith");
            p2_switchTEXT.text = p2_switch;
        }
    }
}
