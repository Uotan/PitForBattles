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
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerPrefs.SetString("Set_p1_left",p1_leftTEXT.text);
        PlayerPrefs.SetString("Set_p1_right", p1_rightTEXT.text);
        PlayerPrefs.SetString("Set_p1_jump", p1_jumpTEXT.text);
        PlayerPrefs.SetString("Set_p1_shoot", p1_shootTEXT.text);
        PlayerPrefs.SetString("Set_p1_swith", p1_switchTEXT.text);
        SceneManager.LoadScene(2);
    }
}
