using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ZatemnualkaTexta : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text textColor;
    public Color _maincolor;
    public Color _changecolor;
    private void Start()
    {
        textColor = GetComponent<Text>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        textColor.color = _changecolor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textColor.color = _maincolor;
    }
}
