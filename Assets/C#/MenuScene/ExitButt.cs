﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButt : MonoBehaviour
{
     private void OnMouseDown() {
         Application.Quit();
     }
    // private void Update()
    // {
    //     if (Input.GetKeyUp(KeyCode.Escape))
    //     {
    //         Application.Quit();
    //     }
    // }
}
