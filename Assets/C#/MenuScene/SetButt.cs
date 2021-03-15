using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetButt : MonoBehaviour
{
    public SpriteRenderer SpriteColor;
    private void Start() {
        SpriteColor = GetComponent<SpriteRenderer>();
    }
     private void OnMouseDown() {
        //SceneManager.LoadScene(2);
    }
     private void OnMouseEnter() {
         Color m_NewColor = new Color(0.64f, 0.64f, 0.64f, 1f);
         SpriteColor.material.color=m_NewColor;
     }
     private void OnMouseExit() {
         Color m_NewColor = new Color(1f, 1f, 1f, 1f);
         SpriteColor.material.color=m_NewColor;
         
     }
}
