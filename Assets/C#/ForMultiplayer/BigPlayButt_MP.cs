using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Mirror;

public class BigPlayButt_MP : MonoBehaviour, IPointerDownHandler
{
    public NetworkManager manager;
    public Text hostaddress;

    public Text net_leftTEXT;
    public Text net_rightTEXT;
    public Text net_jumpTEXT;
    public Text net_shootTEXT;
    public Text net_switchTEXT;

    public Text net_name;

    private void Start()
    {
        manager = GameObject.Find("NetworkManager").GetComponent<NetworkManager>();
    }

    //public int sceneNumb;
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerPrefs.SetString("Set_net_left", net_leftTEXT.text);
        PlayerPrefs.SetString("Set_net_right", net_rightTEXT.text);
        PlayerPrefs.SetString("Set_net_jump", net_jumpTEXT.text);
        PlayerPrefs.SetString("Set_net_shoot", net_shootTEXT.text);
        PlayerPrefs.SetString("Set_net_swith", net_switchTEXT.text);
        PlayerPrefs.SetString("Set_net_name", net_name.text);

        manager.networkAddress = hostaddress.text;
        manager.StartClient();
        //SceneManager.LoadScene(sceneNumb);
    }
}
