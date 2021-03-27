using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButt : MonoBehaviour
{

     private void OnMouseDown() {
         SceneManager.LoadScene(1);
     }
}
