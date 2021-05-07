using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExitEvent : MonoBehaviour
{
    SpriteRenderer _render;
    public Color _changecolor;
    // Start is called before the first frame update
    void Start()
    {
        _render = GetComponent<SpriteRenderer>();
    }
    private void OnMouseEnter()
    {
        _render.color = _changecolor;
    }
    private void OnMouseExit()
    {
        _render.color = new Color(1f, 1f, 1f, 1f);

    }
    
}
