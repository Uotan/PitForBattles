﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BigPlayButt : MonoBehaviour, IPointerDownHandler
{
    //ссылки на строки с кнопками управления
    public Text p1_leftTEXT;
    public Text p1_rightTEXT;
    public Text p1_jumpTEXT;
    public Text p1_shootTEXT;
    public Text p1_switchTEXT;
    //ссылки на строки с кнопками управления
    public Text p2_leftTEXT;
    public Text p2_rightTEXT;
    public Text p2_jumpTEXT;
    public Text p2_shootTEXT;
    public Text p2_switchTEXT;
    //ссылки на строки с именами
    public Text p1_name;
    public Text p2_name;
    //количество карт и номер текущей выбранной сцены 
    public int sceneCount;
    public int CurrentScene;
    public void OnPointerDown(PointerEventData eventData)
    {
        //сохраняем настройки управления для первого игрока
        PlayerPrefs.SetString("Set_p1_left",p1_leftTEXT.text);
        PlayerPrefs.SetString("Set_p1_right", p1_rightTEXT.text);
        PlayerPrefs.SetString("Set_p1_jump", p1_jumpTEXT.text);
        PlayerPrefs.SetString("Set_p1_shoot", p1_shootTEXT.text);
        PlayerPrefs.SetString("Set_p1_swith", p1_switchTEXT.text);
       //сохраняем настройки управления для второго игрока
        PlayerPrefs.SetString("Set_p2_left", p2_leftTEXT.text);
        PlayerPrefs.SetString("Set_p2_right", p2_rightTEXT.text);
        PlayerPrefs.SetString("Set_p2_jump", p2_jumpTEXT.text);
        PlayerPrefs.SetString("Set_p2_shoot", p2_shootTEXT.text);
        PlayerPrefs.SetString("Set_p2_swith", p2_switchTEXT.text);
        //сохраняем введенные никнеймы
        PlayerPrefs.SetString("Set_p1_name", p1_name.text);
        PlayerPrefs.SetString("Set_p2_name", p2_name.text);
        //Запускаем выгранную карту
        //Чтобы карты загружались не по интексу - сцены с картами нужно называть "Pit_" + номер ямы
        SceneManager.LoadScene("Pit_"+CurrentScene.ToString());
    }
}
