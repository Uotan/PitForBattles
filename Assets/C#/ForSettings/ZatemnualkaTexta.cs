using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ZatemnualkaTexta : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text textColor;
    private void Start()
    {
        textColor = GetComponent<Text>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        textColor.color = new Color(0.64f, 0.64f, 0.64f, 1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textColor.color = new Color(1f, 1f, 1f, 1f);
    }
}
