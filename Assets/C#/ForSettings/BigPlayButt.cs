using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BigPlayButt : MonoBehaviour, IPointerDownHandler
{
    public Text p1_leftTEXT;
    public Text p1_rightTEXT;
    public Text p1_jumpTEXT;
    public Text p1_shootTEXT;
    public Text p1_switchTEXT;



    public Text p2_leftTEXT;
    public Text p2_rightTEXT;
    public Text p2_jumpTEXT;
    public Text p2_shootTEXT;
    public Text p2_switchTEXT;



    public Text p1_name;
    public Text p2_name;


    public int sceneNumb;
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerPrefs.SetString("Set_p1_left",p1_leftTEXT.text);
        PlayerPrefs.SetString("Set_p1_right", p1_rightTEXT.text);
        PlayerPrefs.SetString("Set_p1_jump", p1_jumpTEXT.text);
        PlayerPrefs.SetString("Set_p1_shoot", p1_shootTEXT.text);
        PlayerPrefs.SetString("Set_p1_swith", p1_switchTEXT.text);


        PlayerPrefs.SetString("Set_p2_left", p2_leftTEXT.text);
        PlayerPrefs.SetString("Set_p2_right", p2_rightTEXT.text);
        PlayerPrefs.SetString("Set_p2_jump", p2_jumpTEXT.text);
        PlayerPrefs.SetString("Set_p2_shoot", p2_shootTEXT.text);
        PlayerPrefs.SetString("Set_p2_swith", p2_switchTEXT.text);


        PlayerPrefs.SetString("Set_p1_name", p1_name.text);
        PlayerPrefs.SetString("Set_p2_name", p2_name.text);
        SceneManager.LoadScene(sceneNumb);
    }
}
