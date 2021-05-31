using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class check : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public bool active = false;
    public string symbol;
    public Text teext;
    public Color _mainColor;
    public Color _changeColor;
    private void Start()
    {
        teext = GetComponent<Text>();
    }
    void Update()
    {
        if (active==true)
        {
            teext.color = new Color(1f, 0.9681f, 0f, 1f);

            if (Input.GetKeyDown(KeyCode.A)) { symbol = "A"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.B)) { symbol = "B"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.C)) { symbol = "C"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.D)) { symbol = "D"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.E)) { symbol = "E"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.F)) { symbol = "F"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.G)) { symbol = "G"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.H)) { symbol = "H"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.I)) { symbol = "I"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.J)) { symbol = "J"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.K)) { symbol = "K"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.L)) { symbol = "L"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.M)) { symbol = "M"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.N)) { symbol = "N"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.O)) { symbol = "O"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.P)) { symbol = "P"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Q)) { symbol = "Q"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.R)) { symbol = "R"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.S)) { symbol = "S"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.T)) { symbol = "T"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.U)) { symbol = "U"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.V)) { symbol = "V"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.W)) { symbol = "W"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.X)) { symbol = "X"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Y)) { symbol = "Y"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Z)) { symbol = "Z"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Alpha0)) { symbol = "Alpha0"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Alpha1)) { symbol = "Alpha1"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Alpha2)) { symbol = "Alpha2"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Alpha3)) { symbol = "Alpha3"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Alpha4)) { symbol = "Alpha4"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Alpha5)) { symbol = "Alpha5"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Alpha6)) { symbol = "Alpha6"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Alpha7)) { symbol = "Alpha7"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Alpha8)) { symbol = "Alpha8"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Alpha9)) { symbol = "Alpha9"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Keypad0)) { symbol = "Keypad0"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Keypad1)) { symbol = "Keypad1"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Keypad2)) { symbol = "Keypad2"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Keypad3)) { symbol = "Keypad3"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Keypad4)) { symbol = "Keypad4"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Keypad5)) { symbol = "Keypad5"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Keypad6)) { symbol = "Keypad6"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Keypad7)) { symbol = "Keypad7"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Keypad8)) { symbol = "Keypad8"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Keypad9)) { symbol = "Keypad9"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Space)) { symbol = "Space"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.DownArrow)) { symbol = "DownArrow"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.UpArrow)) { symbol = "UpArrow"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.LeftArrow)) { symbol = "LeftArrow"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.RightArrow)) { symbol = "RightArrow"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Mouse0)) { symbol = "Mouse0"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
            else if (Input.GetKeyDown(KeyCode.Mouse1)) { symbol = "Mouse1"; teext.color = _mainColor; teext.text = symbol; active = false; Cursor.lockState = CursorLockMode.None; }
        } 
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        active = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (active!=true)
        {
            teext.color = _changeColor;
            //teext.color = new Color(0.64f, 0.64f, 0.64f, 1f);
        }
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (active !=true )
        {
            teext.color = _mainColor;
            //teext.color = new Color(1f, 1f, 1f, 1f);
        }

    }
}
