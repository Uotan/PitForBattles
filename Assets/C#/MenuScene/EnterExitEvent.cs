using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExitEvent : MonoBehaviour
{
    SpriteRenderer _render;
    // Start is called before the first frame update
    void Start()
    {
        _render = GetComponent<SpriteRenderer>();
    }
    private void OnMouseEnter()
    {
        _render.color = new Color(0.7912183f, 0.8490566f, 0.2923638f, 1f);
    }
    private void OnMouseExit()
    {
        _render.color = new Color(1f, 1f, 1f, 1f);

    }
}
